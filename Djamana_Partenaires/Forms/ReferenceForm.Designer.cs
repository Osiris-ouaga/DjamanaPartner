namespace Djamana.Partenaires.UI.Forms
{
    partial class ReferenceForm
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
            panelReferencesControls = new Panel();
            groupBox1 = new GroupBox();
            buttonCanceled = new Button();
            buttonValidate = new Button();
            pictureBox1 = new PictureBox();
            dateTimePickerReferences = new DateTimePicker();
            labelDate = new Label();
            comboBoxHostel = new ComboBox();
            labelHostel = new Label();
            comboBoxCity = new ComboBox();
            labelCity = new Label();
            labelAdress = new Label();
            labelPhoneNumber = new Label();
            textBoxAdress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            panel1 = new Panel();
            dataGridViewPartners = new DataGridView();
            panelReferencesControls.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).BeginInit();
            SuspendLayout();
            // 
            // panelReferencesControls
            // 
            panelReferencesControls.Controls.Add(groupBox1);
            panelReferencesControls.Dock = DockStyle.Top;
            panelReferencesControls.Location = new Point(0, 0);
            panelReferencesControls.Name = "panelReferencesControls";
            panelReferencesControls.Size = new Size(646, 244);
            panelReferencesControls.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCanceled);
            groupBox1.Controls.Add(buttonValidate);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dateTimePickerReferences);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(comboBoxHostel);
            groupBox1.Controls.Add(labelHostel);
            groupBox1.Controls.Add(comboBoxCity);
            groupBox1.Controls.Add(labelCity);
            groupBox1.Controls.Add(labelAdress);
            groupBox1.Controls.Add(labelPhoneNumber);
            groupBox1.Controls.Add(textBoxAdress);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(labelLastName);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 226);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // buttonCanceled
            // 
            buttonCanceled.Location = new Point(547, 199);
            buttonCanceled.Name = "buttonCanceled";
            buttonCanceled.Size = new Size(75, 23);
            buttonCanceled.TabIndex = 16;
            buttonCanceled.Text = "Annuler";
            buttonCanceled.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(466, 199);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 15;
            buttonValidate.Text = "Ok";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_ClickAsync;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mali2;
            pictureBox1.Location = new Point(400, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dateTimePickerReferences
            // 
            dateTimePickerReferences.Location = new Point(90, 194);
            dateTimePickerReferences.Name = "dateTimePickerReferences";
            dateTimePickerReferences.Size = new Size(207, 23);
            dateTimePickerReferences.TabIndex = 13;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(53, 197);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 12;
            labelDate.Text = "Date";
            // 
            // comboBoxHostel
            // 
            comboBoxHostel.FormattingEnabled = true;
            comboBoxHostel.Location = new Point(90, 165);
            comboBoxHostel.Name = "comboBoxHostel";
            comboBoxHostel.Size = new Size(207, 23);
            comboBoxHostel.TabIndex = 11;
            // 
            // labelHostel
            // 
            labelHostel.AutoSize = true;
            labelHostel.Location = new Point(48, 168);
            labelHostel.Name = "labelHostel";
            labelHostel.Size = new Size(36, 15);
            labelHostel.TabIndex = 10;
            labelHostel.Text = "Hotel";
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(90, 134);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(207, 23);
            comboBoxCity.TabIndex = 9;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(55, 137);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(29, 15);
            labelCity.TabIndex = 8;
            labelCity.Text = "Ville";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(36, 106);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(48, 15);
            labelAdress.TabIndex = 7;
            labelAdress.Text = "Adresse";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(36, 77);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(49, 15);
            labelPhoneNumber.TabIndex = 6;
            labelPhoneNumber.Text = "Contact";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(91, 103);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(206, 23);
            textBoxAdress.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(91, 74);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(206, 23);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(91, 45);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(206, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(36, 48);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(49, 15);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Prénom";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(51, 19);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(91, 16);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 23);
            textBoxName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPartners);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 246);
            panel1.TabIndex = 2;
            // 
            // dataGridViewPartners
            // 
            dataGridViewPartners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartners.Dock = DockStyle.Fill;
            dataGridViewPartners.GridColor = Color.FromArgb(224, 224, 224);
            dataGridViewPartners.Location = new Point(0, 0);
            dataGridViewPartners.Name = "dataGridViewPartners";
            dataGridViewPartners.Size = new Size(646, 246);
            dataGridViewPartners.TabIndex = 0;
            // 
            // ReferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(646, 490);
            Controls.Add(panel1);
            Controls.Add(panelReferencesControls);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReferenceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReferenceForm";
            Load += ReferenceForm_LoadAsync;
            panelReferencesControls.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReferencesControls;
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelAdress;
        private Label labelPhoneNumber;
        private TextBox textBoxAdress;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxHostel;
        private Label labelHostel;
        private ComboBox comboBoxCity;
        private Label labelCity;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePickerReferences;
        private Label labelDate;
        private Button buttonCanceled;
        private Button buttonValidate;
        private Panel panel1;
        private DataGridView dataGridViewPartners;
    }
}