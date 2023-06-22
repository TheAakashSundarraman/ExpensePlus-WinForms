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
        /// <summary>
        /// Private variables are declared here.
        /// Observe the lazy initializiation of the user class, this is done so that the class is called only when needed and 
        /// if the variable is not used, then the JIT complier would do what is called as eager collection to free up memory.
        /// The other variables are used for form movements.
        /// </summary>
        #region Private variables
        private Lazy<BusinessLogic.Login.User> user;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        #endregion
        /// <summary>
        /// Empty constructor instantion of the class where the designer components are instantiated 
        /// and the user class is instatiated via lazy.
        /// </summary>
        #region Constructor
        public Login()
        {
            InitializeComponent();
            user = new Lazy<BusinessLogic.Login.User>();
        }
        #endregion
        /// <summary>
        /// This is the click event for the create account link button on page, which makes a new call to create account form 
        /// and shows as a dialog with login being its parent. This is done to perform show or hide of forms.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new CreateAccount().ShowDialog(this);
        }
        /// <summary>
        /// Main login button click event, makes a call to Authenticate. 
        /// Pushed the authentication functionality outside for leveraging the functionality when a user clicked on enter button on password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(txtPassword.Text)) || (!(string.IsNullOrEmpty(txtUserName.Text))))
                Authenticate();
            else
                MessageBox.Show("Username / Password is mandatory");
        }
        /// <summary>
        /// Authenticat function is the primary function to determine if the user is valid.
        /// Internally calls AuthenticateUser supplying user name and password as parameters.
        /// If the returned user is null the we can safely assume that the user name or password combination is incorrect.
        /// If the returned user is not null then the user has been authenticated and we can show the dashboard.
        /// </summary>
        private void Authenticate()
        {
            if (user.Value != null)
            {
                BusinessLogic.Login.User _user = user.Value.AuthenticateUser(txtUserName.Text, txtPassword.Text);
                if (_user != null)
                {
                    _user.Password = txtPassword.Text;
                    Hide();
                    var dashBoard = new Dashboard();
                    dashBoard.User = _user;
                    dashBoard.ShowDialog();
                }
                else
                    MessageBox.Show("Incorrect username / password combination, please try again!");
            }
        }
        /// <summary>
        /// This event would be called when we click on forgot password link.
        /// It simply creates a new instance of forgotpassword form and hides this.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ForgotPassword().ShowDialog(this);
        }
        /// <summary>
        /// This is a mouse hover that check if show password is checked and if it is, then shows the password character.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPasswordLogin.Checked ? '\0' : '*';
        }
        /// <summary>
        /// This method identifies that the user has clicked on the mouse down button,
        /// once the click has occured the system sets a flag as true, this flag would only be reset after the drag event has finished.
        /// The system also identifies the users current cursor position as a Point (X,Y)
        /// and sets the dragFormPoint to this location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        /// <summary>
        /// Based on the flag set above, the system would go inside and perform a simple difference between what the previous location was
        /// determined the variable dragCursorPoint and the current position and find the difference.
        /// Once the diff is determined the system can now simply move the form from the previous location to the new location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        /// <summary>
        /// Once the user has lifted the mouse button up, the system resets the dragging variable making a safe assumption that the form movement is complete.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        /// <summary>
        /// This is the event that occurs when a user presses enter on the password text box,
        /// the system checks to see if the user has pressed enter and if yes, then would perform authentication.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Authenticate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var p in System.Diagnostics.Process.GetProcessesByName("ExpensePlus"))
            {
                p.Kill();
            }
        }
    }
}
