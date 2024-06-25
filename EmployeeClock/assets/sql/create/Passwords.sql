CREATE TABLE [dbo].[Passwords] (
    [code]          INT          IDENTITY (1, 1) NOT NULL,
    [employee_code] INT          NULL,
    [password]      VARCHAR (12) NULL,
    [expiry_date]   DATE         NULL,
    [has_access]    BIT          NULL,
    PRIMARY KEY CLUSTERED ([code] ASC),
    FOREIGN KEY ([employee_code]) REFERENCES [dbo].[Employees] ([code])
);