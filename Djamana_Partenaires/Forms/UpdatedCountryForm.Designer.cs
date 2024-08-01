namespace Djamana.Partenaires.UI.Forms
{
    partial class UpdatedCountryForm
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
            btnValidate = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            labelDateCountry = new Label();
            textBoxCountryName = new TextBox();
            lbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(labelDateCountry);
            groupBox1.Controls.Add(textBoxCountryName);
            groupBox1.Controls.Add(lbl);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajouter un nouveau pays";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(91, 101);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(75, 23);
            btnValidate.TabIndex = 5;
            btnValidate.Text = "Ok";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(176, 101);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(91, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
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
            textBoxCountryName.Size = new Size(189, 23);
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
            // UpdatedCountryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(299, 144);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdatedCountryForm";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}