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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            tmrForm.Enabled = true;
        }

        private void tmrForm_Tick(object sender, EventArgs e)
        {
            tmrForm.Enabled = false;

            for (int d = 0; d < 100; d++)
            {
                Thread.Sleep(100);
                pgBar.Value = d;
            }
            Hide();
            new Login().Show();
        }
    }
}
