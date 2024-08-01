namespace Djamana.Partenaires.UI.Forms
{
    partial class CountriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountriesForm));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnValidate = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelDateCountry = new Label();
            textBoxCountryName = new TextBox();
            lbl = new Label();
            dataGridViewCountry = new DataGridView();
            contextMenuStripCountry = new ContextMenuStrip(components);
            toolStripMenuItemUpdateCountry = new ToolStripMenuItem();
            toolStripMenuItemDeleteCountry = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).BeginInit();
            contextMenuStripCountry.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(labelDateCountry);
            groupBox1.Controls.Add(textBoxCountryName);
            groupBox1.Controls.Add(lbl);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter un nouveau pays";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(124, 101);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 5;
            btnValidate.Text = "Ok";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_ClickAsync;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(205, 101);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // labelDateCountry
            // 
            labelDateCountry.AutoSize = true;
            labelDateCountry.Location = new Point(54, 65);
            labelDateCountry.Name = "labelDateCountry";
            labelDateCountry.Size = new Size(31, 15);
            labelDateCountry.TabIndex = 2;
            labelDateCountry.Text = "Date";
            // 
            // textBoxCountryName
            // 
            textBoxCountryName.Location = new Point(91, 30);
            textBoxCountryName.Name = "textBoxCountryName";
            textBoxCountryName.Size = new Size(232, 23);
            textBoxCountryName.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(15, 33);
            lbl.Name = "lbl";
            lbl.Size = new Size(70, 15);
            lbl.TabIndex = 0;
            lbl.Text = "Désignation";
            // 
            // dataGridViewCountry
            // 
            dataGridViewCountry.AllowUserToAddRows = false;
            dataGridViewCountry.AllowUserToDeleteRows = false;
            dataGridViewCountry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCountry.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCountry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountry.ContextMenuStrip = contextMenuStripCountry;
            dataGridViewCountry.Location = new Point(12, 148);
            dataGridViewCountry.Name = "dataGridViewCountry";
            dataGridViewCountry.ReadOnly = true;
            dataGridViewCountry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCountry.Size = new Size(520, 211);
            dataGridViewCountry.TabIndex = 1;
            // 
            // contextMenuStripCountry
            // 
            contextMenuStripCountry.Items.AddRange(new ToolStripItem[] { toolStripMenuItemUpdateCountry, toolStripMenuItemDeleteCountry });
            contextMenuStripCountry.Name = "contextMenuStripCountry";
            contextMenuStripCountry.Size = new Size(169, 48);
            // 
            // toolStripMenuItemUpdateCountry
            // 
            toolStripMenuItemUpdateCountry.Name = "toolStripMenuItemUpdateCountry";
            toolStripMenuItemUpdateCountry.Size = new Size(168, 22);
            toolStripMenuItemUpdateCountry.Text = "Modifier le pays";
            toolStripMenuItemUpdateCountry.Click += toolStripMenuItemUpdateCountry_Click;
            // 
            // toolStripMenuItemDeleteCountry
            // 
            toolStripMenuItemDeleteCountry.Name = "toolStripMenuItemDeleteCountry";
            toolStripMenuItemDeleteCountry.Size = new Size(168, 22);
            toolStripMenuItemDeleteCountry.Text = "Supprimer le pays";
            toolStripMenuItemDeleteCountry.Click += toolStripMenuItemDeleteCountry_Click;
            // 
            // CountriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(544, 366);
            Controls.Add(dataGridViewCountry);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CountriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CountriesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).EndInit();
            contextMenuStripCountry.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl;
        private DataGridView dataGridViewCountry;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private Label labelDateCountry;
        private TextBox textBoxCountryName;
        private Button btnValidate;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStripCountry;
        private ToolStripMenuItem toolStripMenuItemUpdateCountry;
        private ToolStripMenuItem toolStripMenuItemDeleteCountry;
    }
}