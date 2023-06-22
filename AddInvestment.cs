using ExpensePlus.BusinessLogic.Data;
using ExpensePlus.BusinessLogic.Login;
using Microsoft.VisualBasic.FileIO;
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
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public AddInvestment() => InitializeComponent();

        private void btnAddInvestment_Click(object sender, EventArgs e)
        {
            if (_investments == null)
            {
                _investments = new ExpensePlus.BusinessLogic.Data.Investments(user);
                _investments.IsNew = true;
            }
            try
            {
                if (txtInvestmentName.Visible)
                    _investments.InvestmentName = txtInvestmentName.Text;
                else
                {
                    var stockMasterData = pnlAddInvestmentHeaders.Controls.OfType<ComboBox>().ToList();
                    if (stockMasterData != null)
                    {
                        _investments.InvestmentName = stockMasterData.Find(x => x.Name.ToString() == "cmbStockMaster").SelectedValue.ToString();
                    }
                }
                _investments.InvestmentDate = dtInvestmentDate.Value;
                _investments.InvestmentDescription = txtInvestmentDescription.Text;
                _investments.InvestmentAmount = decimal.Parse(txtInvestmentAmount.Text);
                _investments.InvestmentTypeId = int.Parse(cmbInvestmentType.SelectedValue.ToString());
                if (_investments.AddInvestmentForUser(user))
                {
                    if (_investments.IsNew)
                    {
                        MessageBox.Show("Investment added successfully!");
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Investment updated successfully!");
                    }
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
            cmbInvestmentType.SelectedIndex = 0;
            dtInvestmentDate.Value = DateTime.Now;
            _investments = null;
        }
        private void AddInvestment_Load(object sender, EventArgs e)
        {
            var leftNavigation = new LeftNavigation();
            leftNavigation.User = user;
            pnlLeftNav.Controls.Add(leftNavigation);
            leftNavigation.Dock = DockStyle.Fill;
            var ds = new InvestmentType().GetAllInvestmentTypes();
            cmbInvestmentType.DataSource = ds.Tables[0];
            cmbInvestmentType.DisplayMember = "InvestmentTypeName";
            cmbInvestmentType.ValueMember = "InvestmentTypeId";
            btnAddInvestment.Text = "Add Investment";
            if (_investments != null)
            {
                lblCreateInvestmentHeader.Text = "Modify Investment";
                txtInvestmentName.Text = _investments.InvestmentName;
                txtInvestmentAmount.Text = _investments.InvestmentAmount.ToString();
                txtInvestmentDescription.Text = _investments.InvestmentDescription;
                cmbInvestmentType.SelectedValue = _investments.InvestmentTypeId;
                dtInvestmentDate.Text = _investments.InvestmentDate.ToString();
                btnAddInvestment.Text = "Modify Investment";
            }
        }
        private void BindStockNameForUser()
        {
            txtInvestmentName.Visible = true;
            if (cmbInvestmentType.Text.ToUpper() == "STOCK")
            {
                var stockMasterList = GetStockInformationFromNasdaq();
                txtInvestmentName.Visible = false;
                ComboBox stockMaster = new ComboBox();
                stockMaster.Name = "cmbStockMaster";
                stockMaster.Location = new Point(15, 63);
                stockMaster.Size = new Size(313, 27);
                stockMaster.DisplayMember = "StockName";
                stockMaster.ValueMember = "StockSymbol";
                stockMaster.DataSource = stockMasterList;
                pnlAddInvestmentHeaders.Controls.Add(stockMaster);
            }
        }
        private List<Stock> GetStockInformationFromNasdaq()
        {
            var csvLines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Database\\nasdaq_stock_data.csv");
            var csvLinesData = csvLines.Skip(1).Select(x => x.Split(',')).ToArray();
            var stockMasterList = csvLinesData.Select(x => new Stock() { StockSymbol = x[0], StockName = x[1] }).ToList();
            return stockMasterList;
        }
        private void AddInvestment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void cmbInvestmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInvestmentType.Text.ToUpper() == "STOCK")
                BindStockNameForUser();
            else
                txtInvestmentName.Visible = true;
        }

        private void AddInvestment_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void AddInvestment_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AddInvestment_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
