CREATE TABLE [dbo].[Author] (
    [Id]      INT          NOT NULL,
    [Name]    NVARCHAR(50) COLLATE Latin1_General_100_CI_AI_SC_UTF8 NULL,
    [Country] NVARCHAR(50) COLLATE Latin1_General_100_CI_AI_SC_UTF8 NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[TypePhrase] (
    [Id]   INT          NOT NULL,
    [Name] NVARCHAR (50) COLLATE Latin1_General_100_CI_AI_SC_UTF8 NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Phrase] (
    [Id]            INT           NOT NULL,
    [Author_Id]     INT           NULL,
    [TypePhrase_Id] INT           NULL,
    [Value]         NVARCHAR(MAX) COLLATE Latin1_General_100_CI_AI_SC_UTF8 NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Author] FOREIGN KEY ([Author_Id]) REFERENCES [dbo].[Author] ([Id]),
    CONSTRAINT [FK_TypePhrase] FOREIGN KEY ([TypePhrase_Id]) REFERENCES [dbo].[TypePhrase] ([Id])
);