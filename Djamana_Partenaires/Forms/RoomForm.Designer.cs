namespace Djamana.Partenaires.UI.Forms
{
    partial class RoomForm
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            btnValidate = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelDateCountry = new Label();
            textBoxCountryName = new TextBox();
            lbl = new Label();
            dataGridViewCountry = new DataGridView();
            comboBoxHostel = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(comboBoxHostel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
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
            groupBox1.Size = new Size(684, 203);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter un nouveau type de chambre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 112);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 11;
            label2.Text = "Hôtels";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre lit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 9;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(91, 51);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(232, 23);
            textBoxPrice.TabIndex = 7;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(41, 54);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(44, 15);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Type lit";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(125, 174);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 5;
            btnValidate.Text = "Ok";
            btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(206, 174);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(91, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelDateCountry
            // 
            labelDateCountry.AutoSize = true;
            labelDateCountry.Location = new Point(54, 144);
            labelDateCountry.Name = "labelDateCountry";
            labelDateCountry.Size = new Size(31, 15);
            labelDateCountry.TabIndex = 2;
            labelDateCountry.Text = "Date";
            // 
            // textBoxCountryName
            // 
            textBoxCountryName.Location = new Point(91, 22);
            textBoxCountryName.Name = "textBoxCountryName";
            textBoxCountryName.Size = new Size(232, 23);
            textBoxCountryName.TabIndex = 1;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(4, 25);
            lbl.Name = "lbl";
            lbl.Size = new Size(81, 15);
            lbl.TabIndex = 0;
            lbl.Text = "Type chambre";
            // 
            // dataGridViewCountry
            // 
            dataGridViewCountry.AllowUserToAddRows = false;
            dataGridViewCountry.AllowUserToDeleteRows = false;
            dataGridViewCountry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCountry.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCountry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCountry.Location = new Point(0, 203);
            dataGridViewCountry.Name = "dataGridViewCountry";
            dataGridViewCountry.ReadOnly = true;
            dataGridViewCountry.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCountry.Size = new Size(684, 165);
            dataGridViewCountry.TabIndex = 5;
            // 
            // comboBoxHostel
            // 
            comboBoxHostel.FormattingEnabled = true;
            comboBoxHostel.Location = new Point(91, 109);
            comboBoxHostel.Name = "comboBoxHostel";
            comboBoxHostel.Size = new Size(232, 23);
            comboBoxHostel.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(387, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 168);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(684, 368);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewCountry);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCountry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private Button btnValidate;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private Label labelDateCountry;
        private TextBox textBoxCountryName;
        private Label lbl;
        private DataGridView dataGridViewCountry;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxHostel;
        private PictureBox pictureBox1;
    }
}