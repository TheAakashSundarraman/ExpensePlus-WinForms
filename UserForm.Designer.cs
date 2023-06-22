namespace ExpensePlus
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            dataGridUsers = new DataGridView();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsers
            // 
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Location = new Point(12, 12);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.RowTemplate.Height = 25;
            dataGridUsers.Size = new Size(752, 281);
            dataGridUsers.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(625, 311);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 59);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(dataGridUsers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridUsers;
        private Button btnSave;
    }
}