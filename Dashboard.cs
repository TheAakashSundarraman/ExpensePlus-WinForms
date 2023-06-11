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
using Windows.Networking.Vpn;

namespace ExpensePlus
{
    public partial class Dashboard : Form
    {
        public User _user { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(User user)
        {
            _user = user;
        }

        private void tlstrpLogout_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }
        private void CloseApplication()
        {
            Application.Exit();
        }

        private void investmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openInvestmentDialog();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Expenses().ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnInvestments_Click(object sender, EventArgs e)
        {
            openInvestmentDialog();
        }
        private void openInvestmentDialog()
        {
            var investments = new Investments();
            investments.user = _user;
            investments.ShowDialog(this);
        }
    }
}
