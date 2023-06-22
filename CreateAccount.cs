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
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
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
                user.Value.RoleID = new Role().GetAllRoles().AsEnumerable().Where(x => x.Field<string>("RoleType") == "AD").Select(x => x.Field<Guid>("RoleID").ToString()).FirstOrDefault();
                if (chkLstBoxGender.SelectedItem != null)
                    user.Value.GenderID = gender.Value.GetGenderIDbyValue(chkLstBoxGender.SelectedItem.ToString());
                SecretKeyQuestionAnswers secretKeyQuestionAnswers = new SecretKeyQuestionAnswers();
                secretKeyQuestionAnswers.SecretKeyQuestion = txtSecretKeyQuestion.Text;
                secretKeyQuestionAnswers.SecretKeyAnswer = txtSecretKeyAnswer.Text;
                if (new BusinessLogic.Login.User().GetUserByEmail(txtEmail.Text) != null)
                {
                    MessageBox.Show("User Already exists, please login or use the forgot password screen");
                    this.Hide();
                    return;
                }
                if (user.Value.AddUser(secretKeyQuestionAnswers))
                {
                    MessageBox.Show("User Added successfully, please login using the credentials.");
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

        private void btnBackToLoginCreateAccountOne_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Login().ShowDialog(this);
        }

        private void CreateAccount_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CreateAccount_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void CreateAccount_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Login().ShowDialog();
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPasswordCreate.Checked ? '\0' : '*';
        }
    }
}
