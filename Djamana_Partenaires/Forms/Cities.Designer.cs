namespace Djamana.Partenaires.UI.Forms
{
    partial class Cities
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
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            comboBoxCountries = new ComboBox();
            labelCountries = new Label();
            dateTimePickerCities = new DateTimePicker();
            labelDate = new Label();
            textBoxCitiesName = new TextBox();
            labelCitiesName = new Label();
            panel2 = new Panel();
            dataGridViewCities = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(comboBoxCountries);
            panel1.Controls.Add(labelCountries);
            panel1.Controls.Add(dateTimePickerCities);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(textBoxCitiesName);
            panel1.Controls.Add(labelCitiesName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 132);
            panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(477, 103);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(396, 103);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Ok";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(90, 55);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(185, 23);
            comboBoxCountries.TabIndex = 5;
            // 
            // labelCountries
            // 
            labelCountries.AutoSize = true;
            labelCountries.Location = new Point(53, 58);
            labelCountries.Name = "labelCountries";
            labelCountries.Size = new Size(31, 15);
            labelCountries.TabIndex = 4;
            labelCountries.Text = "Pays";
            // 
            // dateTimePickerCities
            // 
            dateTimePickerCities.Location = new Point(331, 12);
            dateTimePickerCities.Name = "dateTimePickerCities";
            dateTimePickerCities.Size = new Size(200, 23);
            dateTimePickerCities.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(294, 15);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Date";
            // 
            // textBoxCitiesName
            // 
            textBoxCitiesName.Location = new Point(90, 12);
            textBoxCitiesName.Name = "textBoxCitiesName";
            textBoxCitiesName.Size = new Size(185, 23);
            textBoxCitiesName.TabIndex = 1;
            // 
            // labelCitiesName
            // 
            labelCitiesName.AutoSize = true;
            labelCitiesName.Location = new Point(14, 15);
            labelCitiesName.Name = "labelCitiesName";
            labelCitiesName.Size = new Size(70, 15);
            labelCitiesName.TabIndex = 0;
            labelCitiesName.Text = "Désignation";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewCities);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 193);
            panel2.TabIndex = 1;
            // 
            // dataGridViewCities
            // 
            dataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.Dock = DockStyle.Fill;
            dataGridViewCities.Location = new Point(0, 0);
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.Size = new Size(564, 193);
            dataGridViewCities.TabIndex = 0;
            // 
            // Cities
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(564, 323);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Cities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cities";
            Load += Cities_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewCities;
        private Label labelCitiesName;
        private ComboBox comboBoxCountries;
        private Label labelCountries;
        private DateTimePicker dateTimePickerCities;
        private Label labelDate;
        private TextBox textBoxCitiesName;
        private Button buttonCancel;
        private Button buttonSave;
    }
}