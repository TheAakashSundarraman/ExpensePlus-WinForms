using ExpensePlus.BusinessLogic.Data;
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
    public partial class AddInvestment : Form
    {
        public BusinessLogic.Data.Investments _investments { get; set; }
        public User user { get; set; }
        public AddInvestment()
        {
            InitializeComponent();
        }

        private void btnAddInvestment_Click(object sender, EventArgs e)
        {
            if (_investments == null)
                _investments = new ExpensePlus.BusinessLogic.Data.Investments(user);
            try
            {
                _investments.InvestmentName = txtInvestmentName.Text;
                _investments.InvestmentDate = dtInvestmentDate.Value;
                _investments.InvestmentDescription = txtInvestmentDescription.Text;
                _investments.InvestmentAmount = decimal.Parse(txtInvestmentAmount.Text);
                _investments.InvestmentTypeId = int.Parse(cmbInvestmentType.SelectedValue.ToString());
                if (_investments.AddInvestmentForUser(user))
                {
                    MessageBox.Show("Investment added successfully!");
                    ClearControls();
                }
                else
                    MessageBox.Show("Error occured during investment addition, please try again!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured during investment addition, please try again!");
                Console.WriteLine(ex.Message);
            }
        }

        private void ClearControls()
        {
            txtInvestmentName.Text = "";
            txtInvestmentAmount.Text = "";
            txtInvestmentDescription.Text = "";
            cmbInvestmentType.SelectedIndex = 1;
            dtInvestmentDate.Value = DateTime.Now;
        }
        private void AddInvestment_Load(object sender, EventArgs e)
        {
            cmbInvestmentType.DisplayMember = "InvestmentTypeName";
            cmbInvestmentType.ValueMember = "InvestmentTypeID";
            cmbInvestmentType.DataSource = new InvestmentType().GetAllInvestmentTypes().Select(x => new { x.InvestmentTypeID, x.InvestmentTypeName }).ToList();
            btnAddInvestment.Text = "Add Investment";
            if (_investments != null)
            {
                txtInvestmentName.Text = _investments.InvestmentName;
                txtInvestmentAmount.Text = _investments.InvestmentAmount.ToString();
                txtInvestmentDescription.Text = _investments.InvestmentDescription;
                cmbInvestmentType.SelectedValue = _investments.InvestmentTypeId;
                dtInvestmentDate.Text = _investments.InvestmentDate.ToString();
                btnAddInvestment.Text = "Modify Investment";
            }
        }

        private void AddInvestment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Investments investment = (Investments)this.Owner;
            if (investment != null)
            {
                investment.user = this.user;
                investment.BindControls();
            }
        }
    }
}
