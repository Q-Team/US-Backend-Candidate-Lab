CREATE TABLE [dbo].[CPB_User] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [UserName]  NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_CPB_User] PRIMARY KEY ([Id]),
	CONSTRAINT [UK_CPB_User_UserName] UNIQUE ([UserName])
)