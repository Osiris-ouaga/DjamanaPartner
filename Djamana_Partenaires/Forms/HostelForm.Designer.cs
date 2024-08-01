namespace Djamana.Partenaires.UI.Forms
{
    partial class HostelForm
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
            dataGridViewHostel = new DataGridView();
            contextMenuStripHostel = new ContextMenuStrip(components);
            modifierLhôtelToolStripMenuItem = new ToolStripMenuItem();
            supprimerLhôtelToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            buttonCanceled = new Button();
            buttonValidate = new Button();
            dateTimePickerReferences = new DateTimePicker();
            labelDate = new Label();
            comboBoxCity = new ComboBox();
            labelAdress = new Label();
            labelPhoneNumber = new Label();
            textBoxAdress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            lblCity = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            panelReferencesControls = new Panel();
            groupBox2 = new GroupBox();
            chartHostel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonHostelServices = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHostel).BeginInit();
            contextMenuStripHostel.SuspendLayout();
            panel1.SuspendLayout();
            panelReferencesControls.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartHostel).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewHostel
            // 
            dataGridViewHostel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHostel.ContextMenuStrip = contextMenuStripHostel;
            dataGridViewHostel.Dock = DockStyle.Fill;
            dataGridViewHostel.Location = new Point(0, 0);
            dataGridViewHostel.Name = "dataGridViewHostel";
            dataGridViewHostel.Size = new Size(660, 204);
            dataGridViewHostel.TabIndex = 0;
            // 
            // contextMenuStripHostel
            // 
            contextMenuStripHostel.Items.AddRange(new ToolStripItem[] { modifierLhôtelToolStripMenuItem, supprimerLhôtelToolStripMenuItem });
            contextMenuStripHostel.Name = "contextMenuStripHostel";
            contextMenuStripHostel.Size = new Size(181, 70);
            // 
            // modifierLhôtelToolStripMenuItem
            // 
            modifierLhôtelToolStripMenuItem.Name = "modifierLhôtelToolStripMenuItem";
            modifierLhôtelToolStripMenuItem.Size = new Size(180, 22);
            modifierLhôtelToolStripMenuItem.Text = "Modifier l'hôtel";
            modifierLhôtelToolStripMenuItem.Click += modifierLhôtelToolStripMenuItem_Click;
            // 
            // supprimerLhôtelToolStripMenuItem
            // 
            supprimerLhôtelToolStripMenuItem.Name = "supprimerLhôtelToolStripMenuItem";
            supprimerLhôtelToolStripMenuItem.Size = new Size(180, 22);
            supprimerLhôtelToolStripMenuItem.Text = "Supprimer l'hôtel";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewHostel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 204);
            panel1.TabIndex = 4;
            // 
            // buttonCanceled
            // 
            buttonCanceled.Location = new Point(179, 209);
            buttonCanceled.Name = "buttonCanceled";
            buttonCanceled.Size = new Size(75, 23);
            buttonCanceled.TabIndex = 16;
            buttonCanceled.Text = "Annuler";
            buttonCanceled.UseVisualStyleBackColor = true;
            // 
            // buttonValidate
            // 
            buttonValidate.Location = new Point(98, 209);
            buttonValidate.Name = "buttonValidate";
            buttonValidate.Size = new Size(75, 23);
            buttonValidate.TabIndex = 15;
            buttonValidate.Text = "Ok";
            buttonValidate.UseVisualStyleBackColor = true;
            buttonValidate.Click += buttonValidate_Click;
            // 
            // dateTimePickerReferences
            // 
            dateTimePickerReferences.Location = new Point(77, 180);
            dateTimePickerReferences.Name = "dateTimePickerReferences";
            dateTimePickerReferences.Size = new Size(205, 23);
            dateTimePickerReferences.TabIndex = 13;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(45, 186);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 12;
            labelDate.Text = "Date";
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(77, 42);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(207, 23);
            comboBoxCity.TabIndex = 9;
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(28, 100);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(48, 15);
            labelAdress.TabIndex = 7;
            labelAdress.Text = "Adresse";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(27, 154);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(49, 15);
            labelPhoneNumber.TabIndex = 6;
            labelPhoneNumber.Text = "Contact";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(78, 71);
            textBoxAdress.Multiline = true;
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(206, 74);
            textBoxAdress.TabIndex = 5;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(77, 151);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(206, 23);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(47, 48);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(29, 15);
            lblCity.TabIndex = 2;
            lblCity.Text = "Ville";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Désignation";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(78, 13);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 23);
            textBoxName.TabIndex = 1;
            // 
            // panelReferencesControls
            // 
            panelReferencesControls.Controls.Add(groupBox2);
            panelReferencesControls.Controls.Add(groupBox1);
            panelReferencesControls.Dock = DockStyle.Top;
            panelReferencesControls.Location = new Point(0, 0);
            panelReferencesControls.Name = "panelReferencesControls";
            panelReferencesControls.Size = new Size(660, 244);
            panelReferencesControls.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartHostel);
            groupBox2.Controls.Add(buttonHostelServices);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(307, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 244);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // chartHostel
            // 
            chartArea1.Name = "ChartArea1";
            chartHostel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartHostel.Legends.Add(legend1);
            chartHostel.Location = new Point(6, 16);
            chartHostel.Name = "chartHostel";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartHostel.Series.Add(series1);
            chartHostel.Size = new Size(341, 169);
            chartHostel.TabIndex = 18;
            // 
            // buttonHostelServices
            // 
            buttonHostelServices.Location = new Point(99, 201);
            buttonHostelServices.Name = "buttonHostelServices";
            buttonHostelServices.Size = new Size(208, 37);
            buttonHostelServices.TabIndex = 17;
            buttonHostelServices.Text = "Ajouter un nouveau service hôtélier";
            buttonHostelServices.UseVisualStyleBackColor = true;
            buttonHostelServices.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCanceled);
            groupBox1.Controls.Add(buttonValidate);
            groupBox1.Controls.Add(dateTimePickerReferences);
            groupBox1.Controls.Add(labelDate);
            groupBox1.Controls.Add(comboBoxCity);
            groupBox1.Controls.Add(labelAdress);
            groupBox1.Controls.Add(labelPhoneNumber);
            groupBox1.Controls.Add(textBoxAdress);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 244);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // HostelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(660, 448);
            Controls.Add(panel1);
            Controls.Add(panelReferencesControls);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HostelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += HostelForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHostel).EndInit();
            contextMenuStripHostel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelReferencesControls.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartHostel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewHostel;
        private Panel panel1;
        private Button buttonCanceled;
        private Button buttonValidate;
        private DateTimePicker dateTimePickerReferences;
        private Label labelDate;
        private ComboBox comboBoxCity;
        private Label labelAdress;
        private Label labelPhoneNumber;
        private TextBox textBoxAdress;
        private TextBox textBoxPhoneNumber;
        private Label lblCity;
        private Label labelName;
        private TextBox textBoxName;
        private Panel panelReferencesControls;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button buttonHostelServices;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHostel;
        private ContextMenuStrip contextMenuStripHostel;
        private ToolStripMenuItem modifierLhôtelToolStripMenuItem;
        private ToolStripMenuItem supprimerLhôtelToolStripMenuItem;
    }
}