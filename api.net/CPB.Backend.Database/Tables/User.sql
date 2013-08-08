CREATE TABLE [dbo].[CPB_User]
(
	[Id] INT NOT NULL  IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY ([UserName], [Id])
)