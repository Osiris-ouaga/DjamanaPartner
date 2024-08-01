namespace Djamana.Partenaires.UI.Forms
{
    partial class UpdatingHostelForm
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
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Size = new Size(359, 245);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
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
            // UpdatingHostelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(359, 245);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdatingHostelForm";
            StartPosition = FormStartPosition.CenterParent;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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
    }
}