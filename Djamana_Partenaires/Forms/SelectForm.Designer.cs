namespace Djamana.Partenaires.UI.Forms
{
    partial class SelectForm
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
            panelGridView = new Panel();
            panelDataExport = new Panel();
            dataGridViewSelectData = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panelGridView.SuspendLayout();
            panelDataExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelectData).BeginInit();
            SuspendLayout();
            // 
            // panelGridView
            // 
            panelGridView.Controls.Add(dataGridViewSelectData);
            panelGridView.Dock = DockStyle.Top;
            panelGridView.Location = new Point(0, 0);
            panelGridView.Name = "panelGridView";
            panelGridView.Size = new Size(800, 388);
            panelGridView.TabIndex = 0;
            // 
            // panelDataExport
            // 
            panelDataExport.Controls.Add(button2);
            panelDataExport.Controls.Add(button1);
            panelDataExport.Dock = DockStyle.Fill;
            panelDataExport.Location = new Point(0, 388);
            panelDataExport.Name = "panelDataExport";
            panelDataExport.Size = new Size(800, 62);
            panelDataExport.TabIndex = 1;
            // 
            // dataGridViewSelectData
            // 
            dataGridViewSelectData.AllowUserToAddRows = false;
            dataGridViewSelectData.AllowUserToDeleteRows = false;
            dataGridViewSelectData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSelectData.Dock = DockStyle.Fill;
            dataGridViewSelectData.Location = new Point(0, 0);
            dataGridViewSelectData.Name = "dataGridViewSelectData";
            dataGridViewSelectData.ReadOnly = true;
            dataGridViewSelectData.Size = new Size(800, 388);
            dataGridViewSelectData.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(283, 10);
            button1.Name = "button1";
            button1.Size = new Size(123, 42);
            button1.TabIndex = 0;
            button1.Text = "Exporter sous format excel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(412, 10);
            button2.Name = "button2";
            button2.Size = new Size(134, 42);
            button2.TabIndex = 1;
            button2.Text = "Sauvegarder la base de données";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDataExport);
            Controls.Add(panelGridView);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SelectForm";
            Text = "SelectForm";
            panelGridView.ResumeLayout(false);
            panelDataExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelectData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGridView;
        private Panel panelDataExport;
        private DataGridView dataGridViewSelectData;
        private Button button2;
        private Button button1;
    }
}