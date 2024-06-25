CREATE TABLE [dbo].[Shifts] (
    [code]          INT      IDENTITY (1, 1) NOT NULL,
    [employee_code] INT      NULL,
    [entry_time]    DATETIME NULL,
    [exit_time]     DATETIME NULL,
    PRIMARY KEY CLUSTERED ([code] ASC),
    FOREIGN KEY ([employee_code]) REFERENCES [dbo].[Employees] ([code])
);

