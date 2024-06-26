using EmployeeClock.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class LoginForm : Form
    {
        DatabaseManager _databaseManager;
        FormHandler _formHandler;

        public LoginForm(DatabaseManager databaseManager, FormHandler formHandler)
        {
            _databaseManager = databaseManager;
            InitializeComponent();
            _formHandler = formHandler;
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {
            // allow only numbers

        }

        /// <summary>
        /// Handles the click event of the submit button on the login form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An EventArgs that contains no event data.</param>
        /// <remarks>
        /// This method retrieves the username and password entered by the user, checks if either field is empty,
        /// and displays a message if so. If both fields are filled, it validates the login credentials against the database.
        /// Upon successful validation, a success message is shown, the clock form is displayed, and the login form is closed.
        /// If validation fails, an error message is displayed.
        /// </remarks>
        private void Button_submit_Click(object sender, EventArgs e)
        {
            string username = textBox_id.Text;
            string password = textBox_password.Text;

            //if username or pasword empty return
            if (username == "" || password == "")
            {
                MessageBox.Show("נא למלא את כל השדות");
                return;
            }
            DataTable loggedInUser = CheckLogin(username, password);

            string db_id = loggedInUser.Rows[0]["code"].ToString();

            MessageBox.Show(db_id != string.Empty ? "התחברת בהצלחה" : "שם משתמש או סיסמא שגויים");
            ApplicationState.Instance.username = username;
            ApplicationState.Instance.userId = db_id;
            _formHandler.ShowForm("ClockForm", true);
            this.Close();
        }

        private DataTable CheckLogin(string username, string password)
        {
            string query = $@"SELECT * FROM Employees 
                                INNER JOIN Passwords 
                                ON Employees.code = Passwords.employee_code 
                                WHERE Employees.id = '{username}' 
                                AND passwords.password = '{password}'";

            DataTable result = _databaseManager.ExecuteQuery(query);
            return result;
            //DataTable result = _databaseManager.ExecuteQuery(query);
            //return result.Rows.Count != 0;
        }

        private void Button_change_password_Click(object sender, EventArgs e)
        {
            _formHandler.ShowForm("PasswordChangeForm", true);
        }
    }
}
