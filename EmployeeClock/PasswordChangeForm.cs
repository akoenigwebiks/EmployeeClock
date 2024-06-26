using EmployeeClock.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class PasswordChangeForm : Form
    {
        private readonly DatabaseManager _databaseManager;
        FormHandler _formHandler;
        public PasswordChangeForm(DatabaseManager databaseManager, FormHandler formHandler)
        {
            InitializeComponent();
            _databaseManager = databaseManager;
            _formHandler = formHandler;
        }

        private void Button_submit_Click(object sender, EventArgs e)
        {
            string username = textBox_id.Text;
            string oldPassword = textBox_oldPassword.Text;
            string newPassowrd = textBox_newPassword.Text;
            string newPassowrdConfirm = textBox_newPasswordConfirm.Text;

            // if any field is empty return
            if (username == "" || oldPassword == "" || newPassowrd == "" || newPassowrdConfirm == "")
            {
                MessageBox.Show("נא למלא את כל השדות");
                return;
            }

            // if new passwords do not match return
            if (newPassowrd != newPassowrdConfirm)
            {
                MessageBox.Show("הערכים בשדות סיסמא חדשה ואישור סיסמא חדשה אינם זהים");
                return;
            }

            // get the employee code
            string query = $@"SELECT * FROM Employees INNER JOIN Passwords 
	                            ON Employees.code = Passwords.employee_code 
	                            WHERE Employees.id = '{username}' 
	                            AND passwords.password = '{oldPassword}'";
            DataTable result = _databaseManager.ExecuteQuery(query);
            
            // if no results found, show error message
            if (result.Rows.Count == 0)
            {
                MessageBox.Show("שם משתמש או סיסמא שגויים");
                return;
            }

            // update the password
            string updateQuery = $@"UPDATE Passwords 
                                    SET password = '{newPassowrd}' 
                                    WHERE employee_code = '{result.Rows[0]["code"]}'";

            int updateResultResult = _databaseManager.ExecuteNonQuery(updateQuery);
            if (updateResultResult == 1)
            {
                MessageBox.Show("הסיסמא שונתה בהצלחה");
                _formHandler.ShowForm("LoginForm", true);
                this.Close();
            }
            else
            {
                MessageBox.Show("שגיאה בעת שינוי הסיסמא");
            }
        }

        private void link_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formHandler.ShowForm("LoginForm", true);
        }
    }
}
