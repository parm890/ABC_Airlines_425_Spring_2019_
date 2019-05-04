CREATE TABLE [dbo].[Payment] (
    [AccountNumber]  INT          NOT NULL,
    [CardNumber]     NUMERIC (16) NOT NULL,
    [ExiprationDate] DATE         NOT NULL,
    [CVV]            NUMERIC (3)  NOT NULL,
    [NameAsDispayed] CHAR (40)    NOT NULL,
    [Address line 1] NCHAR(30) NOT NULL, 
    [Address lline 2] NCHAR(10) NOT NULL, 
    [City] CHAR(30) NOT NULL, 
    [Country] CHAR(20) NOT NULL, 
    [State] CHAR(2) NOT NULL, 
    [Zip] NCHAR(5) NOT NULL, 
    CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED ([CardNumber] ASC)
);

