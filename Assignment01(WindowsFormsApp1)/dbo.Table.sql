CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [username] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL, 
    [fname] NVARCHAR(100) NULL,
	[lname] NVARCHAR(100) NULL,
	[email] NVARCHAR(100) NULL,
	[address] NVARCHAR(MAX) NULL,
	[image] NVARCHAR(MAX) NULL
)
