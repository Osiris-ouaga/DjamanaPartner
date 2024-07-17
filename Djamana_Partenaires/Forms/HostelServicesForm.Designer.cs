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
            groupBox1 = new GroupBox();
            listBoxHostel = new ListBox();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            btnValidate = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelDateCountry = new Label();
            textBoxCountryName = new TextBox();
            lbl = new Label();
            dataGridViewCountry = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxHostel);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(labelDateCountry);
            groupBox1.Controls.Add(textBoxCountryName);
            groupBox1.Controls.Add(lbl);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 163);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter un nouveau service";
            // 
            // listBoxHostel
            // 
            listBoxHostel.BackColor = SystemColors.Menu;
            listBoxHostel.Dock = DockStyle.Right;
            listBoxHostel.FormattingEnabled = true;
            listBoxHostel.ItemHeight = 15;
            listBoxHostel.Location = new Point(329, 19);
            listBoxHostel.Name = "listBoxHostel";
            listBoxHostel.SelectionMode = SelectionMode.MultiSimple;
            listBoxHostel.Size = new Size(242, 141);
            listBoxHostel.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(91, 62);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(152, 23);
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
            btnValidate.Location = new Point(44, 134);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 5;
            btnValidate.Text = "Ok";
            btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(135, 134);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // labelDateCountry
            // 
            labelDateCountry.AutoSize = true;
            labelDateCountry.Location = new Point(54, 102);
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
            dataGridViewCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCountry.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCountry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountry.Dock = DockStyle.Fill;
            dataGridViewCountry.Location = new Point(0, 0);
            dataGridViewCountry.Name = "dataGridViewCountry";
            dataGridViewCountry.ReadOnly = true;
            dataGridViewCountry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCountry.Size = new Size(574, 367);
            dataGridViewCountry.TabIndex = 3;
            // 
            // HostelServicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(574, 367);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCountry);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HostelServicesForm";
            Text = "HostelServicesForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnValidate;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private Label labelDateCountry;
        private TextBox textBoxCountryName;
        private Label lbl;
        private DataGridView dataGridViewCountry;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private ListBox listBoxHostel;
    }
}