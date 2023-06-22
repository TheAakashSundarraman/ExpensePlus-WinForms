using Accessibility;
using ExpensePlus.BusinessLogic.Common;
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
    public partial class Profile : Form
    {
        public User user { get; set; }
        private Lazy<Gender> gender;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public Profile()
        {
            InitializeComponent();
            gender = new Lazy<Gender>();
        }
        public Profile(User _user)
        {
            user = _user;
        }

        private void txtCurentPassword_MouseHover(object sender, EventArgs e)
        {
            txtCurentPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtPhone.Text = user.PhoneNumber;
                txtEmail.Text = user.Email;
                txtEmail.ReadOnly = true;
                dtDateofBirth.Value = user.DateofBirth;
                foreach (DataRow item in gender.Value.GetAllGender().Rows)
                {
                    if (user.GenderID == Convert.ToUInt32(item[0].ToString()))
                        chkGender.Items.Add(item[1], true);
                    else
                        chkGender.Items.Add(item[1]);
                }
                txtCurentPassword.Text = user.Password;
                txtSecretKeyQuestion.Text = user.SecretKeyQuestion;
                txtSecretKeyQuestion.ReadOnly = true;
                var leftNavigation = new LeftNavigation
                {
                    User = user,
                    Width = 250,
                    Height = 806
                };
                pnlLeftNavigation.Controls.Add(leftNavigation);
                leftNavigation.Dock = DockStyle.Fill;
            }
        }

        private void chkGender_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chkGender.Items.Count; ++ix)
                if (ix != e.Index) chkGender.SetItemChecked(ix, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.PhoneNumber = txtPhone.Text;
            user.DateofBirth = dtDateofBirth.Value;
            if (chkGender.CheckedItems != null)
                user.GenderID = gender.Value.GetGenderIDbyValue(chkGender.CheckedItems[0].ToString());
            if (user.UpdateUser())
                MessageBox.Show("Profile updated succesfully!");
            else
                MessageBox.Show("Error occured during profile update, please try again!");
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtReenternewpwd.Text)
            {
                MessageBox.Show("New passwords do not match, please try again!");
                txtNewPassword.Text = "";
                txtReenternewpwd.Text = "";
                return;
            }
            if (user.IsSecretAnswerCorrect(user.UserID, Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSecretKeyAnswer.Text))))
            {
                user.Password = txtNewPassword.Text;
                if (user.UpdatePassword())
                    MessageBox.Show("Password updated successfully!");
            }
            else
            {
                MessageBox.Show("Secret Key Answer is incorrect, please try again!");
            }
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void Profile_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Profile_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Profile_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void txtNewPassword_MouseHover(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = chkShowNewPwd.Checked ? '\0' : '*';
        }

        private void chkReenterNewPwd_MouseHover(object sender, EventArgs e)
        {
            txtReenternewpwd.PasswordChar = chkReenterNewPwd.Checked ? '\0' : '*';
        }
    }
}
