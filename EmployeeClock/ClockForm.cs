using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock
{
    struct ClockData
    {
        public string EmployeeName;
        public string ClockInTime;
        public string ClockOutTime;
    }
    public partial class ClockForm : Form
    {
        DatabaseManager _databaseManager;
        FormHandler _formHandler;
        string _employeeUsername;

        public ClockForm(DatabaseManager databaseManager, FormHandler formHandler)
        {
            InitializeComponent();
            _databaseManager = databaseManager;
            _formHandler = formHandler;
            _employeeUsername = ApplicationState.Instance.username;
        }

        private ClockData? GetInitialData()
        {

            string query= $@"SELECT e.id, s.*
                                FROM Employees e
                                INNER JOIN Shifts s ON e.code = s.employee_code
                                INNER JOIN (
                                    SELECT employee_code, MAX(entry_time) AS MaxEntryTime
                                    FROM Shifts
                                    GROUP BY employee_code
                                ) ms ON s.employee_code = ms.employee_code AND s.entry_time = ms.MaxEntryTime
                                WHERE e.id = {_employeeUsername};";

            DataTable lastShift = _databaseManager.ExecuteQuery(query);

            return new ClockData();
        }

        private void link_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formHandler.ShowForm("LoginForm", true);
        }

        private void Load_initial_data(object sender, EventArgs e)
        {
            // if _employeeUsername is null return to login
            if (_employeeUsername == string.Empty)
            {
                MessageBox.Show("אירעה שגיאה - שם משתמש לא נשמר במערכת");
                _formHandler.ShowForm("LoginForm", true);
                return;
            }

            ClockData data = GetInitialData().Value;

        }
    }
}
