CREATE TABLE [dbo].[accounts] (
    [Id]       INT           NOT NULL,
    [Email] NVARCHAR (20) NOT NULL,
    [PassWord] NVARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Email])
);

