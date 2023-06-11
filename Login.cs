using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensePlus
{
    public partial class Login : Form
    {
        private Lazy<BusinessLogic.Login.User> user;
        public Login()
        {
            InitializeComponent();
            user = new Lazy<BusinessLogic.Login.User>();
        }

        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CreateAccount().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Value != null)
            {
                BusinessLogic.Login.User _user = user.Value.AuthenticateUser(txtUserName.Text, txtPassword.Text);
                if (_user != null)
                {
                    Hide();
                    var dashBoard = new Dashboard();
                    dashBoard._user = _user;
                    dashBoard.ShowDialog();
                }
            }
        }
    }
}
