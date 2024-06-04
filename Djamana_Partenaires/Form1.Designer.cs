namespace Djamana_Partenaires
{
    partial class FrmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            btnAdmin = new Button();
            btnResourcesPerson = new Button();
            btnHostel = new Button();
            btnCity = new Button();
            BtnCountry = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            slideOneUserControl1 = new UserControls.SlideOneUserControl();
            slideTwoUsercontrol1 = new UserControls.SlideTwoUsercontrol();
            slideThreeUserControl1 = new UserControls.SlideThreeUserControl();
            slideFourUserControl1 = new UserControls.SlideFourUserControl();
            slideFiveUserControl1 = new UserControls.SlideFiveUserControl();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 43);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Brush Script MT", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(440, 2);
            label1.Name = "label1";
            label1.Size = new Size(339, 41);
            label1.TabIndex = 0;
            label1.Text = "Djamana Tours Partenaires";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnAdmin);
            panel2.Controls.Add(btnResourcesPerson);
            panel2.Controls.Add(btnHostel);
            panel2.Controls.Add(btnCity);
            panel2.Controls.Add(BtnCountry);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 626);
            panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(24, 440);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 49);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Consulter";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Location = new Point(24, 364);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(148, 49);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "Administrateur";
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnResourcesPerson
            // 
            btnResourcesPerson.FlatStyle = FlatStyle.Popup;
            btnResourcesPerson.Location = new Point(24, 294);
            btnResourcesPerson.Name = "btnResourcesPerson";
            btnResourcesPerson.Size = new Size(148, 49);
            btnResourcesPerson.TabIndex = 3;
            btnResourcesPerson.Text = "Personnes ressource";
            btnResourcesPerson.UseVisualStyleBackColor = true;
            btnResourcesPerson.Click += button1_Click;
            // 
            // btnHostel
            // 
            btnHostel.FlatStyle = FlatStyle.Popup;
            btnHostel.Location = new Point(24, 224);
            btnHostel.Name = "btnHostel";
            btnHostel.Size = new Size(148, 49);
            btnHostel.TabIndex = 2;
            btnHostel.Text = "Hotels";
            btnHostel.UseVisualStyleBackColor = true;
            // 
            // btnCity
            // 
            btnCity.FlatStyle = FlatStyle.Popup;
            btnCity.Location = new Point(24, 150);
            btnCity.Name = "btnCity";
            btnCity.Size = new Size(148, 49);
            btnCity.TabIndex = 1;
            btnCity.Text = "Villes";
            btnCity.UseVisualStyleBackColor = true;
            // 
            // BtnCountry
            // 
            BtnCountry.FlatStyle = FlatStyle.Popup;
            BtnCountry.Location = new Point(24, 68);
            BtnCountry.Name = "BtnCountry";
            BtnCountry.Size = new Size(148, 49);
            BtnCountry.TabIndex = 0;
            BtnCountry.Text = "Pays";
            BtnCountry.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(864, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 626);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(6, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(slideOneUserControl1);
            panel4.Controls.Add(slideTwoUsercontrol1);
            panel4.Controls.Add(slideThreeUserControl1);
            panel4.Controls.Add(slideFourUserControl1);
            panel4.Controls.Add(slideFiveUserControl1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(664, 626);
            panel4.TabIndex = 3;
            // 
            // slideOneUserControl1
            // 
            slideOneUserControl1.BackColor = Color.Red;
            slideOneUserControl1.Dock = DockStyle.Fill;
            slideOneUserControl1.Location = new Point(0, 0);
            slideOneUserControl1.Name = "slideOneUserControl1";
            slideOneUserControl1.Size = new Size(664, 626);
            slideOneUserControl1.TabIndex = 0;
            // 
            // slideTwoUsercontrol1
            // 
            slideTwoUsercontrol1.BackColor = Color.FromArgb(0, 64, 64);
            slideTwoUsercontrol1.Dock = DockStyle.Fill;
            slideTwoUsercontrol1.Location = new Point(0, 0);
            slideTwoUsercontrol1.Name = "slideTwoUsercontrol1";
            slideTwoUsercontrol1.Size = new Size(664, 626);
            slideTwoUsercontrol1.TabIndex = 0;
            // 
            // slideThreeUserControl1
            // 
            slideThreeUserControl1.BackColor = Color.DarkOrange;
            slideThreeUserControl1.Dock = DockStyle.Fill;
            slideThreeUserControl1.Location = new Point(0, 0);
            slideThreeUserControl1.Name = "slideThreeUserControl1";
            slideThreeUserControl1.Size = new Size(664, 626);
            slideThreeUserControl1.TabIndex = 0;
            // 
            // slideFourUserControl1
            // 
            slideFourUserControl1.BackColor = Color.IndianRed;
            slideFourUserControl1.Dock = DockStyle.Fill;
            slideFourUserControl1.Location = new Point(0, 0);
            slideFourUserControl1.Name = "slideFourUserControl1";
            slideFourUserControl1.Size = new Size(664, 626);
            slideFourUserControl1.TabIndex = 0;
            // 
            // slideFiveUserControl1
            // 
            slideFiveUserControl1.BackColor = SystemColors.ActiveCaption;
            slideFiveUserControl1.Dock = DockStyle.Fill;
            slideFiveUserControl1.Location = new Point(0, 0);
            slideFiveUserControl1.Name = "slideFiveUserControl1";
            slideFiveUserControl1.Size = new Size(664, 626);
            slideFiveUserControl1.TabIndex = 0;
            slideFiveUserControl1.Load += slideFiveUserControl1_Load;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Location = new Point(24, 516);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(148, 49);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Déconnexion";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 669);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private UserControls.SlideFiveUserControl slideFiveUserControl1;
        private UserControls.SlideFourUserControl slideFourUserControl1;
        private UserControls.SlideOneUserControl slideOneUserControl1;
        private UserControls.SlideTwoUsercontrol slideTwoUsercontrol1;
        private UserControls.SlideThreeUserControl slideThreeUserControl1;
        private PictureBox pictureBox1;
        private Button BtnCountry;
        private Button btnResourcesPerson;
        private Button btnHostel;
        private Button btnCity;
        private Button btnSearch;
        private Button btnAdmin;
        private Button btnLogOut;
    }
}
