using System;
using System.Text;
using Q.Common.Managers;
using Q.Common.DTO.Queries;
using CPB.Backend.Common.Entities;
using CPB.Backend.Common.Managers;
using System.Collections.Generic;

namespace CPB.Backend.Common.Managers
{
    public interface INoteManager : IBaseManager<Note, BaseQueryFilters>
    {
        bool ValidateNoteOwner(int userId, int noteId);
        List<Note> SearchNotes(int userId, string searchValue);
    }
}
