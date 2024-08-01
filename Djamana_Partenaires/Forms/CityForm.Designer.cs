namespace Djamana.Partenaires.UI.Forms
{
    partial class CityForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            chartCity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonCancel = new Button();
            buttonSave = new Button();
            comboBoxCountries = new ComboBox();
            labelCountries = new Label();
            textBoxCitiesName = new TextBox();
            labelCitiesName = new Label();
            panel2 = new Panel();
            dataGridViewCities = new DataGridView();
            contextMenuStripCities = new ContextMenuStrip(components);
            toolStripMenuItemUpdateCities = new ToolStripMenuItem();
            toolStripMenuItemDeleteCities = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).BeginInit();
            contextMenuStripCities.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chartCity);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(comboBoxCountries);
            panel1.Controls.Add(labelCountries);
            panel1.Controls.Add(textBoxCitiesName);
            panel1.Controls.Add(labelCitiesName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 132);
            panel1.TabIndex = 0;
            // 
            // chartCity
            // 
            chartArea1.Name = "ChartArea1";
            chartCity.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCity.Legends.Add(legend1);
            chartCity.Location = new Point(293, 3);
            chartCity.Name = "chartCity";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCity.Series.Add(series1);
            chartCity.Size = new Size(268, 126);
            chartCity.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(169, 103);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(73, 103);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(90, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Ok";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
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
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 193);
            panel2.TabIndex = 1;
            // 
            // dataGridViewCities
            // 
            dataGridViewCities.AllowUserToAddRows = false;
            dataGridViewCities.AllowUserToDeleteRows = false;
            dataGridViewCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCities.ContextMenuStrip = contextMenuStripCities;
            dataGridViewCities.Dock = DockStyle.Fill;
            dataGridViewCities.Location = new Point(0, 0);
            dataGridViewCities.Name = "dataGridViewCities";
            dataGridViewCities.ReadOnly = true;
            dataGridViewCities.Size = new Size(564, 193);
            dataGridViewCities.TabIndex = 0;
            // 
            // contextMenuStripCities
            // 
            contextMenuStripCities.Items.AddRange(new ToolStripItem[] { toolStripMenuItemUpdateCities, toolStripMenuItemDeleteCities });
            contextMenuStripCities.Name = "contextMenuStripCities";
            contextMenuStripCities.Size = new Size(130, 48);
            contextMenuStripCities.Opening += contextMenuStripCities_Opening;
            // 
            // toolStripMenuItemUpdateCities
            // 
            toolStripMenuItemUpdateCities.Name = "toolStripMenuItemUpdateCities";
            toolStripMenuItemUpdateCities.Size = new Size(129, 22);
            toolStripMenuItemUpdateCities.Text = "Modifier";
            toolStripMenuItemUpdateCities.Click += toolStripMenuItemUpdateCities_Click;
            // 
            // toolStripMenuItemDeleteCities
            // 
            toolStripMenuItemDeleteCities.Name = "toolStripMenuItemDeleteCities";
            toolStripMenuItemDeleteCities.Size = new Size(129, 22);
            toolStripMenuItemDeleteCities.Text = "Supprimer";
            toolStripMenuItemDeleteCities.Click += toolStripMenuItemDeleteCities_Click;
            // 
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(564, 323);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cities";
            Load += Cities_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartCity).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCities).EndInit();
            contextMenuStripCities.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewCities;
        private Label labelCitiesName;
        private ComboBox comboBoxCountries;
        private Label labelCountries;
        private TextBox textBoxCitiesName;
        private Button buttonCancel;
        private Button buttonSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCity;
        private ContextMenuStrip contextMenuStripCities;
        private ToolStripMenuItem toolStripMenuItemUpdateCities;
        private ToolStripMenuItem toolStripMenuItemDeleteCities;
    }
}