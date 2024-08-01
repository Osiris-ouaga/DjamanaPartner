using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.UI.Helper
{
    public static class DataGridViewHelper
    {
        public static void StyleDataGridView(DataGridView dataGridView)
        {
            // Style général
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            // Sélection de toute la ligne
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;

            // Masquer la colonne de sélection
            dataGridView.RowHeadersVisible = false;

            // Style des en-têtes de colonnes
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 64, 0); // Couleur personnalisée
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 64, 0); // Conserver la même couleur lors de la sélection
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // Ajuster la hauteur des lignes
            dataGridView.RowTemplate.Height = 30;

            // Ajuster la largeur des colonnes automatiquement
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajuster l'alignement du texte dans les cellules
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Désactiver le mode de tri sur toutes les colonnes
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Ajouter des bordures aux cellules
            dataGridView.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Changer la couleur du texte des cellules
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;

            // Changer la police du texte des cellules
            dataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 9); 

            // Alignement du texte dans les en-têtes de colonnes
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Couleur de fond des en-têtes de colonnes
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 64, 0);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
