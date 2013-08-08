using System;
using System.Text;
using Q.Domain;
using Q.Common.DTO.Queries;
using Q.DataAccess;
using CPB.Backend.Common.Entities;
using CPB.Backend.DataAccess;
using System.Collections.Generic;

namespace CPB.Backend.Domain.Managers
{
    /// <summary>
    /// Manager note entities. Allow:
    ///     - Create
    ///     - Update
    ///     - Delete
    ///     - Query
    /// </summary>
    public partial class NoteManager : BaseManager<NoteDataAccess, Note, BaseQueryFilters>
    {
        #region -- Constructors --

        public NoteManager()
        {
        }

        public NoteManager(QDatabase dac)
            : base(dac)
        {
        }

        #endregion

        #region -- Public Methods --

        public bool ValidateNoteOwner(int userId, int noteId)
        {
            return this.DAC.ValidateNoteOwner(userId, noteId);
        }

        public List<Note> SearchNotes(int userId, string searchValue)
        {
            return this.DAC.SearchNotes(userId, searchValue);
        }

        #endregion

        #region -- Private Methods --

        #endregion
    }
}
