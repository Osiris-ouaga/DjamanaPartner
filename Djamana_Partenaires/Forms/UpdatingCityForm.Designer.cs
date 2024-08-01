namespace Djamana.Partenaires.UI.Forms
{
    partial class UpdatingCityForm
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
            textBoxCitiesName = new TextBox();
            labelCitiesName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(comboBoxCountries);
            panel1.Controls.Add(labelCountries);
            panel1.Controls.Add(textBoxCitiesName);
            panel1.Controls.Add(labelCitiesName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 132);
            panel1.TabIndex = 1;
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
            // UpdatingCityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 141);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdatingCityForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonCancel;
        private Button buttonSave;
        private ComboBox comboBoxCountries;
        private Label labelCountries;
        private TextBox textBoxCitiesName;
        private Label labelCitiesName;
    }
}