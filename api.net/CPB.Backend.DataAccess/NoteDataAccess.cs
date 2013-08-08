using System;
using System.Text;
using Q.DataAccess;
using Q.Common.DTO.Queries;
using Q.Common.Configurations;
using CPB.Backend.Common.Entities;
using CPB.Backend.DataAccess.DBMappers;
using Q.DataAccess.Utils;
using System.Data.Common;
using System.Data;
using System.Collections.Generic;

namespace CPB.Backend.DataAccess
{
    public partial class NoteDataAccess : BaseDataAccess<NoteDBMapper, Note, BaseQueryFilters, Int32>
    {
        #region -- Constructors --

        public NoteDataAccess() { }

        public NoteDataAccess(string connName) : base(connName) { }

        public NoteDataAccess(QDatabase database) : base(database) { }

        #endregion

        #region -- Override Methods --

        protected override bool DoCreate(Note entity)
        {
            if (base.DataBaseType == DataBaseType.Oracle)
            {
                entity.Id = base.GetNextSequense(entity);
                base.DoCreate(entity);
            }
            else
            {
                entity.Id = base.DoCreateIdentity(entity);
            }
            return entity.Id > 0;
        }

        #endregion

        #region -- Public Methods --

        public bool ValidateNoteOwner(int userId, int noteId)
        {
            bool result = false;

            string sqlText = DataAccessHelper.GetQuery("NoteDataAccess.ValidateNoteOwner");
            using (DbCommand command = base.GetSqlStringCommand(sqlText))
            {
                DBMapperHelper.AddInParameter<int>(this, command, "userId", userId);
                DBMapperHelper.AddInParameter<int>(this, command, "noteId", noteId);
                using (IDataReader reader = base.ExecuteReader(command))
                {
                    if (reader.Read())
                        result = true;
                }
            }

            return result;
        }

        public List<Note> SearchNotes(int userId, string searchValue)
        {
            List<Note> result = null;

            string sqlText = DataAccessHelper.GetQuery("NoteDataAccess.SearchNotes");
            using (DbCommand command = base.GetSqlStringCommand(sqlText))
            {
                DBMapperHelper.AddInParameter<int>(this, command, "userId", userId);
                DBMapperHelper.AddInParameter<string>(this, command, "searchValue", string.Format("%{0}%", searchValue));
                using (IDataReader reader = base.ExecuteReader(command))
                {
                    DBMapperHelper.ReadToEnd<Note>(reader, mapper.BuildEntity);
                }
            }

            return result;
        }

        #endregion

        #region -- Private Methods --

        #endregion

    }
}
