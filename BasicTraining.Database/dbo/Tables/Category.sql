CREATE TABLE [dbo].[Category] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (100) NOT NULL,
    [Slug] VARCHAR (100)  NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Category_Slug]
    ON [dbo].[Category]([Slug] ASC);

