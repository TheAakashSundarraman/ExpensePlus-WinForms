namespace ExpensePlus
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            pnlLogo = new Panel();
            logoImage = new PictureBox();
            pgBar = new ProgressBar();
            tmrForm = new System.Windows.Forms.Timer(components);
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImageLayout = ImageLayout.Center;
            pnlLogo.Controls.Add(logoImage);
            pnlLogo.Location = new Point(425, 50);
            pnlLogo.Margin = new Padding(0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(500, 500);
            pnlLogo.TabIndex = 0;
            // 
            // logoImage
            // 
            logoImage.Dock = DockStyle.Fill;
            logoImage.Image = Properties.Resources.EXPENSE;
            logoImage.Location = new Point(0, 0);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(500, 500);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 0;
            logoImage.TabStop = false;
            // 
            // pgBar
            // 
            pgBar.BackColor = Color.Violet;
            pgBar.Location = new Point(425, 590);
            pgBar.Name = "pgBar";
            pgBar.Size = new Size(500, 58);
            pgBar.TabIndex = 1;
            // 
            // tmrForm
            // 
            tmrForm.Tick += tmrForm_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1388, 749);
            Controls.Add(pgBar);
            Controls.Add(pnlLogo);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogo;
        private PictureBox logoImage;
        private ProgressBar pgBar;
        private System.Windows.Forms.Timer tmrForm;
    }
}