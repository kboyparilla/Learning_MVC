CREATE TABLE [dbo].[Users]
(
	[ID]				INT				NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [FirstName]			VARCHAR(50)		NOT NULL, 
    [MiddleName]		VARCHAR(50)		NOT NULL, 
    [LastName]			VARCHAR(50)		NOT NULL, 
    [Email]				VARCHAR(100)	NOT NULL, 
    [ContactNumber]		VARCHAR(15)		NULL		DEFAULT '', 
    [Username]			VARCHAR(50)		NOT NULL, 
    [Password]			VARCHAR(100)	NOT NULL, 
    [Status]			INT				NOT NULL	DEFAULT 0 
)
