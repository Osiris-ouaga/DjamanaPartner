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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelReferencesControls = new Panel();
            groupBox1 = new GroupBox();
            chartReference = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonCanceled = new Button();
            buttonValidate = new Button();
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
            ((System.ComponentModel.ISupportInitialize)chartReference).BeginInit();
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
            panelReferencesControls.Size = new Size(646, 271);
            panelReferencesControls.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartReference);
            groupBox1.Controls.Add(buttonCanceled);
            groupBox1.Controls.Add(buttonValidate);
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
            groupBox1.Size = new Size(631, 256);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // chartReference
            // 
            chartReference.BorderlineColor = Color.Chocolate;
            chartArea1.Name = "ChartArea1";
            chartReference.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartReference.Legends.Add(legend1);
            chartReference.Location = new Point(266, 16);
            chartReference.Name = "chartReference";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SeriesReferences";
            chartReference.Series.Add(series1);
            chartReference.Size = new Size(359, 234);
            chartReference.TabIndex = 17;
            chartReference.Text = "Classement des référents par ville";
            chartReference.MouseLeave += chartReference_MouseLeave;
            chartReference.MouseMove += chartReference_MouseMove;
            // 
            // buttonCanceled
            // 
            buttonCanceled.Location = new Point(147, 223);
            buttonCanceled.Name = "buttonCanceled";
            buttonCanceled.Size = new Size(75, 23);
            buttonCanceled.TabIndex = 16;
            buttonCanceled.Text = "Annuler";
            buttonCanceled.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(66, 223);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 15;
            buttonValidate.Text = "Ok";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_ClickAsync;
            // 
            // dateTimePickerReferences
            // 
            dateTimePickerReferences.Location = new Point(53, 194);
            dateTimePickerReferences.Name = "dateTimePickerReferences";
            dateTimePickerReferences.Size = new Size(207, 23);
            dateTimePickerReferences.TabIndex = 13;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(20, 200);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 12;
            labelDate.Text = "Date";
            // 
            // comboBoxHostel
            // 
            comboBoxHostel.FormattingEnabled = true;
            comboBoxHostel.Location = new Point(52, 163);
            comboBoxHostel.Name = "comboBoxHostel";
            comboBoxHostel.Size = new Size(207, 23);
            comboBoxHostel.TabIndex = 11;
            // 
            // labelHostel
            // 
            labelHostel.AutoSize = true;
            labelHostel.Location = new Point(15, 168);
            labelHostel.Name = "labelHostel";
            labelHostel.Size = new Size(36, 15);
            labelHostel.TabIndex = 10;
            labelHostel.Text = "Hotel";
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(53, 134);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(207, 23);
            comboBoxCity.TabIndex = 9;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(22, 137);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(29, 15);
            labelCity.TabIndex = 8;
            labelCity.Text = "Ville";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(3, 106);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(48, 15);
            labelAdress.TabIndex = 7;
            labelAdress.Text = "Adresse";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(2, 77);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(49, 15);
            labelPhoneNumber.TabIndex = 6;
            labelPhoneNumber.Text = "Contact";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(53, 103);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(206, 23);
            textBoxAdress.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(53, 74);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(206, 23);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(53, 42);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(206, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(2, 48);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(49, 15);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Prénom";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(17, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nom";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(53, 13);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 23);
            textBoxName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPartners);
            panel1.Location = new Point(0, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 216);
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
            dataGridViewPartners.Size = new Size(646, 216);
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
            Load += ReferenceForm_LoadAsync;
            panelReferencesControls.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartReference).EndInit();
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
        private DateTimePicker dateTimePickerReferences;
        private Label labelDate;
        private Button buttonCanceled;
        private Button buttonValidate;
        private Panel panel1;
        private DataGridView dataGridViewPartners;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReference;
    }
}