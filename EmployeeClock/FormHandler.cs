using EmployeeClock.DAL;
using System;

namespace EmployeeClock
{
    struct Forms
    {
        public LoginForm LoginForm;
        public ClockForm ClockForm;
        public PasswordChangeForm PasswordChangeForm;
    }
    public class FormHandler
    {
        private Forms AllForms;
        private DatabaseManager _databaseManager;
        public FormHandler(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            AllForms = new Forms
            {
                LoginForm = new LoginForm(_databaseManager, this),
                ClockForm = new ClockForm(_databaseManager, this),
                PasswordChangeForm = new PasswordChangeForm(_databaseManager, this)
            };
        }

        public void CloseAllForms()
        {
            AllForms.LoginForm.Close();
            AllForms.ClockForm.Close();
            AllForms.PasswordChangeForm.Close();
        }

        public void ShowForm(string formName, bool? closeOthers)
        {
            if (closeOthers == true)
            {
                CloseAllForms();
            }

            switch (formName)
            {
                case "LoginForm":
                    AllForms.LoginForm = new LoginForm(_databaseManager, this);
                    AllForms.LoginForm.Show();
                    break;
                case "ClockForm":
                    AllForms.ClockForm = new ClockForm(_databaseManager, this);
                    AllForms.ClockForm.Show();
                    break;
                case "PasswordChangeForm":
                    AllForms.PasswordChangeForm = new PasswordChangeForm(_databaseManager, this);
                    AllForms.PasswordChangeForm.Show();
                    break;
                default:
                    throw new ArgumentException("Invalid form name");
            }
        }
    }
}
