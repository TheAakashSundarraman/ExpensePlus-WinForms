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
    public partial class ForgotPassword : Form
    {
        public DataSet SecretKeyQuestionAnswers { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnFetchData_Click(object sender, EventArgs e)
        {
            var user = new BusinessLogic.Login.User();
            SecretKeyQuestionAnswers = user.GetSecretKeyQuestionForuser(txtUserName.Text);
            lblSecretKeyQuestion.Text = SecretKeyQuestionAnswers.Tables[0].AsEnumerable().Select(x => x.Field<string>("SecretKeyQuestion")).FirstOrDefault();
            lblSecretKeyQuestion.Visible = true;
            pnlResetPasswordarea.Visible = true;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!SecretKeyQuestionAnswers.Tables[0].AsEnumerable().Any(x => x.Field<string>("SecretKeyAnswer") == Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSecretKeyAnswer.Text))))
            {
                MessageBox.Show("Secret key answer does not match, please try again!");
                return;
            }
            if (txtEnterNewPassword.Text != txtReEnterNewPassword.Text)
            {
                MessageBox.Show("New password(s) do not match, please try again.");
                txtEnterNewPassword.Text = "";
                txtReEnterNewPassword.Text = "";
                return;
            }
            var user = new BusinessLogic.Login.User().GetUserByEmail(txtUserName.Text);
            user.Password = txtEnterNewPassword.Text.Trim();
            if (user.UpdatePassword())
            {
                MessageBox.Show("Updated password successfully, please login using your new password.");
                this.Hide();
                new Login().ShowDialog(this);
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            lblSecretKeyQuestion.Visible = false;
            pnlResetPasswordarea.Visible = false;
        }

        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ForgotPassword_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void ForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void txtEnterNewPassword_MouseHover(object sender, EventArgs e)
        {
            txtEnterNewPassword.PasswordChar = chkShowPasswordEnterPASS.Checked ? '\0' : '*';
        }

        private void txtReEnterNewPassword_MouseHover(object sender, EventArgs e)
        {
            txtReEnterNewPassword.PasswordChar = chkShowPasswordReEnterPASS.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog(this);
        }
    }
}
