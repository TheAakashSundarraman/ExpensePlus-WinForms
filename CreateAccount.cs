using ExpensePlus.BusinessLogic.Login;
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
    public partial class CreateAccount : Form
    {
        private Lazy<Gender> gender;
        private Lazy<BusinessLogic.Login.User> user;
        public CreateAccount()
        {
            InitializeComponent();
            gender = new Lazy<Gender>();
            user = new Lazy<BusinessLogic.Login.User>();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            if (gender.Value != null)
            {
                foreach (DataRow item in gender.Value.GetAllGender().Rows)
                {
                    chkLstBoxGender.Items.Add(item[1]);
                }
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (user.Value != null && gender.Value != null)
            {
                user.Value.UserID = Guid.NewGuid();
                user.Value.FirstName = txtFirstName.Text;
                user.Value.LastName = txtLastName.Text;
                user.Value.DateofBirth = dtDOB.Value;
                user.Value.Email = txtEmail.Text;
                user.Value.PhoneNumber = txtPhone.Text;
                user.Value.Password = txtPassword.Text;
                user.Value.RoleID = "81A80B8D-25A7-469B-AE68-9FBC4054D83B";
                if (chkLstBoxGender.SelectedItem != null)
                    user.Value.GenderID = gender.Value.GetGenderIDbyValue(chkLstBoxGender.SelectedItem.ToString());
                if (user.Value.AddUser())
                {
                    MessageBox.Show("User Added successfully, please login using the credentials.");
                    this.Parent.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("An error occured during the account creation process, please try again!");
            }
        }

        private void chkLstBoxGender_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chkLstBoxGender.Items.Count; ++ix)
                if (ix != e.Index) chkLstBoxGender.SetItemChecked(ix, false);
        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Login().Show();
        }
    }
}
