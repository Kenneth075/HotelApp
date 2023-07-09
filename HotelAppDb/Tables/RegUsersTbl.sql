CREATE TABLE [dbo].[RegUsersTbl] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    [DateTime]  DATETIME      NULL,
    CONSTRAINT [PK_User_Table] PRIMARY KEY CLUSTERED ([Id] ASC)
);