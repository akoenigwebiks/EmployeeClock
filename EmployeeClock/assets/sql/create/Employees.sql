CREATE TABLE [dbo].[Employees] (
    [code]       INT          IDENTITY (1, 1) NOT NULL,
    [id]         VARCHAR (10) NULL,
    [first_name] VARCHAR (15) NULL,
    [last_name]  VARCHAR (15) NULL,
    PRIMARY KEY CLUSTERED ([code] ASC)
);