TO.DO!!!


# CP+B Backend Candidate Lab

## Documentation

API.NETWebService.asmx
	Build with .NET

Users Methods
        public User CreateUser(User user)
        public User UpdateUser(User user)
        public User GetUserByName(string userName)
        public User GetUserById(int userId)
        public User ValidateUser(string userName, string password)


Notes Methods
        public Note CreateNote(Note note)
        public Note UpdateNote(int userId, Note note)
        public Note GetNoteById(int userId, int noteId)
        public List<Note> SearchNotes(int userId, string searchValue)
        public bool DeleteNote(int userId, Note note)
