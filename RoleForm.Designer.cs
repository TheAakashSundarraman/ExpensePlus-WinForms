namespace ExpensePlus
{
    partial class RoleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleForm));
            dataGridViewRoles = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRoles
            // 
            dataGridViewRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoles.Location = new Point(45, 47);
            dataGridViewRoles.Name = "dataGridViewRoles";
            dataGridViewRoles.RowTemplate.Height = 25;
            dataGridViewRoles.Size = new Size(724, 259);
            dataGridViewRoles.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(626, 328);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 50);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewRoles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RoleForm";
            Text = "RoleForm";
            WindowState = FormWindowState.Maximized;
            Load += RoleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRoles;
        private Button btnSave;
    }
}