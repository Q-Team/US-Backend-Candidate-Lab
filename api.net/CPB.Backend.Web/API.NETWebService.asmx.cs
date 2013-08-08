using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using CPB.Backend.Common.Entities;
using CPB.Backend.Domain.Managers;

namespace CPB.Backend.Web
{
    /// <summary>
    /// Summary description for API_NETWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class API_NETWebService : System.Web.Services.WebService
    {
        #region -- User Methods --

        /// <summary>
        /// Create accounts. If the account data is OK, return account info.
        /// </summary>
        /// <param name="user">Account to update</param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User CreateUser(User user)
        {
            User result = null;
            using (UserManager manager = new UserManager())
            {
                result = manager.Create(user);
            }
            return result;
        }

        /// <summary>
        /// Update account data.
        /// </summary>
        /// <param name="user">Account to update</param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User UpdateUser(User user)
        {
            User result = null;

            /// Validte user and password, to update.
            if (ValidateUser(user.UserName, user.Password))
            {
                using (UserManager manager = new UserManager())
                {
                    result = manager.Update(user);
                }
            }

            return result;
        }

        /// <summary>
        /// Get account data by name.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User GetUserByName(string userName)
        {
            User result = null;
            using (UserManager manager = new UserManager())
            {
                result = manager.GetUserByName(userName);
            }
            return result;
        }

        /// <summary>
        /// Get acccount data by id.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User GetUserById(int userId)
        {
            User result = null;
            using (UserManager manager = new UserManager())
            {
                result = manager.GetById(userId);
            }
            return result;
        }

        /// <summary>
        /// Validate user and password. If OK, return account data.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public User ValidateUser(string userName, string password)
        {
            User result = null;
            using (UserManager manager = new UserManager())
            {
                result = manager.ValidateUser(userName, password);
            }
            return result;
        }

        #endregion -- User Methods --

        #region -- Note Methods --

        /// <summary>
        /// Create note data.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Note CreateNote(Note note)
        {
            Note result = null;
            using (NoteManager manager = new NoteManager())
            {
                result = manager.Create(note);
            }
            return result;
        }

        /// <summary>
        /// Update note data.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Note UpdateUser(int userId, Note note)
        {
            Note result = null;
            using (NoteManager manager = new NoteManager())
            {
                if (manager.ValidateNoteOwner(userId, note.Id))
                    result = manager.Update(note);
            }
            return result;
        }

        /// <summary>
        /// Get note info by id.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="noteId"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public Note GetNoteById(int userId, int noteId)
        {
            Note result = null;
            using (NoteManager manager = new NoteManager())
            {
                if (manager.ValidateNoteOwner(userId, noteId))
                    result = manager.GetById(noteId);
            }
            return result;
        }

        /// <summary>
        /// Search for notes.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<Note> SearchNotes(int userId, string searchValue)
        {
            List<Note> result = null;
            using (NoteManager manager = new NoteManager())
            {
                result = manager.SearchNotes(userId, searchValue);
            }
            return result;
        }

        /// <summary>
        /// Delete note by id.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public bool DeleteNote(int userId, Note note)
        {
            bool result = false;
            using (NoteManager manager = new NoteManager())
            {
                if (manager.ValidateNoteOwner(userId, note.Id))
                    result = manager.Delete(note.Id);
            }
            return result;
        }

        #endregion -- Note Methods --
    }
}
