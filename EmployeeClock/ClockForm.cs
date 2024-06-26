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
    public partial class ClockForm : Form
    {
        DatabaseManager _databaseManager;
        FormHandler _formHandler;
        public ClockForm(DatabaseManager databaseManager, FormHandler formHandler)
        {
            InitializeComponent();
            _databaseManager = databaseManager;
            _formHandler = formHandler;
        }

        private void link_to_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _formHandler.ShowForm("LoginForm", true);
        }
    }
}
