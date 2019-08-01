CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CreatTime] DATETIME NOT NULL, 
    [Price] MONEY NULL, 
    [State] TINYINT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Phone] INT NULL, 
    [Title] TINYINT NOT NULL
)
