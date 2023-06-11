using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensePlus
{
    public partial class RoleForm : Form
    {
        DataTable rolesTable;
        SqlDataAdapter dataAdapter;
        BindingSource bindingSource;
        public RoleForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            try
            {
                dataAdapter = new SqlDataAdapter("Select * FROM Role", connection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                rolesTable = new DataTable();
                dataAdapter.Fill(rolesTable);
                bindingSource.DataSource = rolesTable;
                dataGridViewRoles.DataSource = bindingSource;
                dataGridViewRoles.AllowUserToAddRows = true;
                dataGridViewRoles.AllowUserToDeleteRows = true;
                dataGridViewRoles.ReadOnly = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occured during data retrieval, please check Connection");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataAdapter.Update((DataTable)bindingSource.DataSource);
            MessageBox.Show("Roles Saved");
        }
    }
}
