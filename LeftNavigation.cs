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
using Windows.Devices.Input;

namespace ExpensePlus
{
    public partial class LeftNavigation : UserControl
    {
        public User User { get; set; }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public ToolTip ToolTip { get; set; }
        public LeftNavigation()
        {
            InitializeComponent();
            ToolTip = new ToolTip();
        }

        private void LeftNavigation_Load(object sender, EventArgs e)
        {
            if (User != null)
            {
                txtUserInfo.Text = "Logged in user details: \r\n" + User.FirstName + " " + User.LastName;
            }
        }

        private void btnExpenses_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Expenses", this);
        }

        private void btnReporting_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Reporting", this);
        }

        private void btnProfile_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Profile", this);
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Logout", this);
        }

        private void btnInvestments_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Investments", this);
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Show("Dashboard", this);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            var dashboard = new Dashboard();
            dashboard.User = User;
            dashboard.ShowDialog(this);
        }

        private void btnInvestments_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            var investments = new Investments();
            investments.user = User;
            investments.ShowDialog(this);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            var expenses = new Expenses();
            expenses.user = User;
            expenses.ShowDialog(this);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            var reports = new Reports();
            reports.user = User;
            reports.ShowDialog(this);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            var profile = new Profile();
            profile.user = User;
            profile.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            new Login().ShowDialog(this);
        }

        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.ParentForm.Location;

        }

        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.ParentForm.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
