
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            btnAbout = new Button();
            btnResourcesPerson = new Button();
            btnHostel = new Button();
            btnCity = new Button();
            BtnCountry = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panelSlide = new Panel();
            slidePictureBox = new PictureBox();
            bottomSlidePanel = new Panel();
            sliderTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slidePictureBox).BeginInit();
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
            panel1.Paint += panel1_Paint;
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
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(btnAbout);
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
            btnSearch.Location = new Point(24, 363);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 49);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Consulter";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAbout
            // 
            btnAbout.FlatStyle = FlatStyle.Popup;
            btnAbout.Location = new Point(24, 442);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(148, 49);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "A propos";
            btnAbout.UseVisualStyleBackColor = true;
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
            btnHostel.Click += btnHostel_Click;
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
            btnCity.Click += btnCity_Click;
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
            BtnCountry.Click += BtnCountry_Click;
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
            pictureBox1.Image = Djamana.Partenaires.UI.Properties.Resources.logo;
            pictureBox1.Location = new Point(6, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelSlide
            // 
            panelSlide.Controls.Add(slidePictureBox);
            panelSlide.Controls.Add(bottomSlidePanel);
            panelSlide.Dock = DockStyle.Fill;
            panelSlide.Location = new Point(200, 43);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(664, 626);
            panelSlide.TabIndex = 3;
            // 
            // slidePictureBox
            // 
            slidePictureBox.Dock = DockStyle.Fill;
            slidePictureBox.Image = (Image)resources.GetObject("slidePictureBox.Image");
            slidePictureBox.Location = new Point(0, 0);
            slidePictureBox.Name = "slidePictureBox";
            slidePictureBox.Size = new Size(664, 526);
            slidePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            slidePictureBox.TabIndex = 1;
            slidePictureBox.TabStop = false;
            // 
            // bottomSlidePanel
            // 
            bottomSlidePanel.Dock = DockStyle.Bottom;
            bottomSlidePanel.Location = new Point(0, 526);
            bottomSlidePanel.Name = "bottomSlidePanel";
            bottomSlidePanel.Size = new Size(664, 100);
            bottomSlidePanel.TabIndex = 0;
            // 
            // sliderTimer
            // 
            sliderTimer.Enabled = true;
            sliderTimer.Interval = 2000;
            sliderTimer.Tick += sliderTimer_Tick;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 669);
            Controls.Add(panelSlide);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += FrmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)slidePictureBox).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button BtnCountry;
        private Button btnResourcesPerson;
        private Button btnHostel;
        private Button btnCity;
        private Button btnSearch;
        private Button btnAbout;
        private Panel panelSlide;
        private PictureBox slidePictureBox;
        private Panel bottomSlidePanel;
        private System.Windows.Forms.Timer sliderTimer;
    }
}
