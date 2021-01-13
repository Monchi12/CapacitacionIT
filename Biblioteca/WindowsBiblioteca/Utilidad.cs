using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public static class Utilidad
    {
        public static void formatearGrilla(DataGridView grilla )
        {
            grilla.ReadOnly = true;
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
        }
    }
}
