using System;
using System.Data;

namespace EmployeeClock.DAL.Services
{
    public class SeedService
    {
        private DatabaseManager dbManager;

        public SeedService(DatabaseManager manager)
        {
            dbManager = manager;
        }

        public void EnsureDatabaseSetup()
        {
            EnsureTables();
            SeedData();
        }

        /// <summary>
        /// Ensures the necessary database tables (Employees, Passwords, and Shifts) exist.
        /// </summary>
        /// <remarks>
        /// This method checks for the existence of each table before attempting to create it.
        /// If a table does not exist, it is created with the specified schema.
        /// The Employees table includes columns for code, id, first_name, and last_name.
        /// The Passwords table includes columns for code, employee_code, password, expiry_date, and has_access,
        /// with a foreign key reference to the Employees table.
        /// The Shifts table includes columns for code, employee_code, entry_time, and exit_time,
        /// also with a foreign key reference to the Employees table.
        /// </remarks>
        private void EnsureTables()
        {
            string[] sqlStatements = new string[]
            {
        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employees' AND type = 'U')
            CREATE TABLE [dbo].[Employees] (
                [code]       INT          IDENTITY (1, 1) NOT NULL,
                [id]         VARCHAR (10) NULL,
                [first_name] VARCHAR (15) NULL,
                [last_name]  VARCHAR (15) NULL,
                PRIMARY KEY CLUSTERED ([code] ASC)
            );",

        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Passwords' AND type = 'U')
            CREATE TABLE [dbo].[Passwords] (
                [code]          INT          IDENTITY (1, 1) NOT NULL,
                [employee_code] INT          NULL,
                [password]      VARCHAR (12) NULL,
                [expiry_date]   DATE         NULL,
                [has_access]    BIT          NULL,
                PRIMARY KEY CLUSTERED ([code] ASC),
                FOREIGN KEY ([employee_code]) REFERENCES [dbo].[Employees] ([code])
            );",

        @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Shifts' AND type = 'U')
            CREATE TABLE [dbo].[Shifts] (
                [code]          INT      IDENTITY (1, 1) NOT NULL,
                [employee_code] INT      NULL,
                [entry_time]    DATETIME NULL,
                [exit_time]     DATETIME NULL,
                PRIMARY KEY CLUSTERED ([code] ASC),
                FOREIGN KEY ([employee_code]) REFERENCES [dbo].[Employees] ([code])
            );"
            };

            foreach (var sql in sqlStatements)
            {
                dbManager.ExecuteNonQuery(sql);
            }
        }

        public void SeedData()
        {
            if (IsTableEmpty("Employees") && IsTableEmpty("Passwords"))
            {
                string[] employeeIds = { "200024398", "200024367" };
                foreach (var id in employeeIds)
                {
                    dbManager.ExecuteNonQuery($"INSERT INTO Employees (id, first_name, last_name) VALUES ('{id}', 'John', 'Doe')");

                    // Retrieve the last inserted identity using ExecuteQuery and accessing the DataTable
                    DataTable result = dbManager.ExecuteQuery("SELECT MAX(code) FROM Employees;");
                    int employeeCode = Convert.ToInt32(result.Rows[0][0]); // Convert the result to int

                    dbManager.ExecuteNonQuery($"INSERT INTO Passwords (employee_code, password, expiry_date, has_access) VALUES ({employeeCode}, '12345', '2099-12-31', 1)");
                }
            }
        }

        private bool IsTableEmpty(string tableName)
        {
            DataTable dt = dbManager.ExecuteQuery($"SELECT COUNT(*) FROM [{tableName}]");
            return (int)dt.Rows[0][0] == 0;
        }
    }
}
