using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class frmListaAutores : Form
    {
        public frmListaAutores()
        {
            InitializeComponent();
            // asociamos la lista a la grilla
            Utilidad.formatearGrilla(dgvAutores);
            dgvAutores.DataSource = Program.ListaAutores;
        }

        private void ibtnBuscar_Click(object sender, EventArgs e)
        {
            Logica.Autor objLogica = new Logica.Autor();
            int intIdPais = Convert.ToInt32()
        }



    }
}
