using EmployeeClock.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class LoginForm : Form
    {
        DatabaseManager _databaseManager;
        public LoginForm(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            InitializeComponent();
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            // allow only numbers

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string username = textBox_id.Text;
            string password = textBox_password.Text;

            //if username or pasword empty return
            if (username == "" || password == "")
            {
                MessageBox.Show("נא למלא את כל השדות");
                return;
            }
            bool isValidLogin = checkLogin(username, password);
            if (isValidLogin)
            {
                MessageBox.Show("התחברת בהצלחה");
            }
            else
            {
                MessageBox.Show("שם משתמש או סיסמא שגויים");
            }
        }

        private bool checkLogin(string username, string password)
        {
            string query = $@"SELECT * FROM Employees 
                                INNER JOIN Passwords 
                                ON Employees.code = Passwords.employee_code 
                                WHERE Employees.id = '{username}' 
                                AND passwords.password = '{password}'";

            DataTable result = _databaseManager.ExecuteQuery(query);
            return result.Rows.Count != 0;
        }
    }
}
