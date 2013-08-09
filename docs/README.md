TO.DO!!!


# CP+B Backend Candidate Lab

## Documentation

API.NETWebService.asmx
	Build with .NET
	Publish using IIS or similar

#All methods can be called using AJAX with Json data type, and return data parsed in Json

Entities:
	-User = { int Id, string UserName, string Password, string FirstName, string LastName }
	-Note = { int Id, string Title, string Description, int UserId }

Session Methods:
		-Log In:
			/API.NETWebService.asmx/LogIn
			Gets User; Returns session id.
		-Log Off:
			/API.NETWebService.asmx/LogOff
			Gets session id; Returns boolean.
		-Is Session Online?
			/API.NETWebService.asmx/SessionOnline
			Gets User; Returns boolean.

Users Methods:
		-Create user:
			/API.NETWebService.asmx/CreateUser
			Gets User; Returns User.
        -Update user:
			/API.NETWebService.asmx/UpdateUser
			Gets User; Returns User.
        -Get user by name:
			/API.NETWebService.asmx/GetUserByName
			Gets user name; Returns User.
        -Get user by id:
			/API.NETWebService.asmx/GetUserById
			Gets user id; Returns User.
        -Validate user:
			/API.NETWebService.asmx/ValidateUser
			Gets user name and password; Returns User.

Notes Methods:
        -Create note:
			/API.NETWebService.asmx/CreateNote
			Gets Note; Returns Note.
        -Update note:
			/API.NETWebService.asmx/UpdateNote
			Gets user id and Note; Returns Note.
        -Get note:
			/API.NETWebService.asmx/GetNoteById
			Gets user id and note id; Returns Note.
        -Search for notes:
			/API.NETWebService.asmx/SearchNotes
			Gets user id and search value; Returns array of Notes.
        -Delete note:
			/API.NETWebService.asmx/DeleteNote
			Gets user id and Note; Returns boolean.
