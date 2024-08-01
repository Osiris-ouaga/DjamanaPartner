namespace Djamana.Partenaires.UI.Forms
{
    partial class HostelServicesForm
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
            groupBox1 = new GroupBox();
            comboBoxHostel = new ComboBox();
            labelHostels = new Label();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            btnValidate = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelDateCountry = new Label();
            textBoxDesignation = new TextBox();
            lbl = new Label();
            dataGridViewHostel = new DataGridView();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHostel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chart1);
            groupBox1.Controls.Add(comboBoxHostel);
            groupBox1.Controls.Add(labelHostels);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(labelDateCountry);
            groupBox1.Controls.Add(textBoxDesignation);
            groupBox1.Controls.Add(lbl);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter un nouveau service";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxHostel
            // 
            comboBoxHostel.FormattingEnabled = true;
            comboBoxHostel.Location = new Point(91, 97);
            comboBoxHostel.Name = "comboBoxHostel";
            comboBoxHostel.Size = new Size(232, 23);
            comboBoxHostel.TabIndex = 10;
            // 
            // labelHostels
            // 
            labelHostels.AutoSize = true;
            labelHostels.Location = new Point(44, 100);
            labelHostels.Name = "labelHostels";
            labelHostels.Size = new Size(41, 15);
            labelHostels.TabIndex = 9;
            labelHostels.Text = "Hôtels";
            labelHostels.Click += labelHostels_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(91, 62);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(232, 23);
            textBoxPrice.TabIndex = 7;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(58, 70);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(27, 15);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Prix";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(125, 168);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 5;
            btnValidate.Text = "Ok";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_ClickAsync;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(206, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // labelDateCountry
            // 
            labelDateCountry.AutoSize = true;
            labelDateCountry.Location = new Point(54, 138);
            labelDateCountry.Name = "labelDateCountry";
            labelDateCountry.Size = new Size(31, 15);
            labelDateCountry.TabIndex = 2;
            labelDateCountry.Text = "Date";
            // 
            // textBoxDesignation
            // 
            textBoxDesignation.Location = new Point(91, 30);
            textBoxDesignation.Name = "textBoxDesignation";
            textBoxDesignation.Size = new Size(232, 23);
            textBoxDesignation.TabIndex = 1;
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
            // dataGridViewHostel
            // 
            dataGridViewHostel.AllowUserToAddRows = false;
            dataGridViewHostel.AllowUserToDeleteRows = false;
            dataGridViewHostel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewHostel.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewHostel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHostel.Location = new Point(0, 203);
            dataGridViewHostel.Name = "dataGridViewHostel";
            dataGridViewHostel.ReadOnly = true;
            dataGridViewHostel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHostel.Size = new Size(574, 164);
            dataGridViewHostel.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(329, 12);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(239, 185);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // HostelServicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(574, 367);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewHostel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HostelServicesForm";
            Text = "HostelServicesForm";
            Load += HostelServicesForm_LoadAsync;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHostel).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnValidate;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private Label labelDateCountry;
        private TextBox textBoxDesignation;
        private Label lbl;
        private DataGridView dataGridViewHostel;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelHostels;
        private ComboBox comboBoxHostel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}