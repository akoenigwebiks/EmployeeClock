using EmployeeClock.DAL;
using EmployeeClock.Utils;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace EmployeeClock
{
    struct ClockData
    {
        public ClockData(string employeeName, string employeeId, string clockIn, string clockOut)
        {
            EmployeeId = employeeId;
            EmployeeUserName = employeeName;
            ClockInStr = clockIn;
            ClockOutStr = clockOut;
        }

        public ClockData(DataRow shiftRow)
        {
            Func<string, string> GetVal = (key) => ConverterUtils.GetByKey(shiftRow, key);
            EmployeeUserName = GetVal("id");
            ClockInStr = GetVal("entry_time");
            ClockOutStr = GetVal("exit_time");
            EmployeeId = GetVal("employee_code");
        }

        public string EmployeeUserName;
        public string EmployeeId;
        public string ClockInStr;
        public string ClockOutStr;
    }
    public partial class ClockForm : Form
    {
        private readonly DatabaseManager _databaseManager;
        FormHandler _formHandler;
        string _employeeUsername;
        ClockData _currentshiftData;

        public ClockForm(DatabaseManager databaseManager, FormHandler formHandler)
        {
            InitializeComponent();
            _databaseManager = databaseManager;
            _formHandler = formHandler;
            _employeeUsername = ApplicationState.Instance.username;
        }

        private ClockData? GetInitialData()
        {

            string query = $@"SELECT e.id, s.*
                                FROM Employees e
                                INNER JOIN Shifts s ON e.code = s.employee_code
                                INNER JOIN (
                                    SELECT employee_code, MAX(entry_time) AS MaxEntryTime
                                    FROM Shifts
                                    GROUP BY employee_code
                                ) ms ON s.employee_code = ms.employee_code AND s.entry_time = ms.MaxEntryTime
                                WHERE e.id = {_employeeUsername};";

            /*
                 ClockData RowResultToClockData(DataTable shiftRow) => new ClockData(shiftRow.Rows[0]);
                 Func<DataTable,ClockData> RowResultToClockData = (shiftRow) => new ClockData(shiftRow.Rows[0]);
            */
            //return RowResultToClockData(_databaseManager.ExecuteQuery(query));

            DataTable result = _databaseManager.ExecuteQuery(query);
            DataRow shiftRow = result.Rows[0];
            return new ClockData
            {
                EmployeeUserName = shiftRow["id"].ToString(),
                ClockInStr = shiftRow["entry_time"].ToString(),
                ClockOutStr = shiftRow["exit_time"].ToString(),
                EmployeeId = shiftRow["employee_code"].ToString()
            };
        }

        private void GoToLoginForm()
        {
            _formHandler.ShowForm("LoginForm", true);

        }
        private void link_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToLoginForm();
        }

        private string StrToParsedDateStr(string dateStr)
        {
            if (dateStr == string.Empty)
            {
                return string.Empty;
            }
            try
            {
                CultureInfo culture = CultureInfo.CurrentCulture;
                return DateTime.Parse(dateStr).ToString("g", CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return string.Empty;
            }
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

            _currentshiftData = GetInitialData().Value;

            // Convert DateTime to string with culture-specific format
            string clockInStr = StrToParsedDateStr(_currentshiftData.ClockInStr);
            string clockOutStr = StrToParsedDateStr(_currentshiftData.ClockOutStr);

            label_date_last_in.Text = clockInStr;
            label_date_last_out.Text = clockOutStr;
            label_empId.Text = _currentshiftData.EmployeeUserName;
        }

        private void Button_StartWork_Click(object sender, EventArgs e)
        {
            if (_currentshiftData.ClockOutStr.ToString() == string.Empty)
            {
                MessageBox.Show("אירעה שגיאה - אין רישום יציאה על משמרת אחרונה");
                return;
            }
            string query = $@"INSERT INTO Shifts (employee_code, entry_time) 
                                VALUES ({_currentshiftData.EmployeeId}, '{DateTime.Now}');";
            DataTable newShift = _databaseManager.ExecuteQuery(query);
            MessageBox.Show("המשמרת התחילה בהצלחה");
            GoToLoginForm();
        }

        private void Button_endWork_Click(object sender, EventArgs e)
        {
            if (_currentshiftData.ClockOutStr.ToString() != string.Empty)
            {
                MessageBox.Show("אירעה שגיאה - קיים כבר רישום יציאה משמרת נוכחית");
                return;
            }

            string query = $@"UPDATE Shifts
                                SET exit_time = '{DateTime.Now}'
                                WHERE employee_code = {_employeeUsername} AND entry_time = '{_currentshiftData.ClockInStr}';";
            DataTable endShift = _databaseManager.ExecuteQuery(query);
            MessageBox.Show("המשמרת הסתיימה בהצלחה");
            GoToLoginForm();
        }
    }
}
