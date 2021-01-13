using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class frmAltaAutor : Form
    {
        public frmAltaAutor()
        {
            InitializeComponent();
            // subscribir el click de btnCerrar

            btnCerrar.Click += ManejoBotones;
            btnConfirmar.Click += ManejoBotones;

        }

        private void ManejoBotones(object sender, EventArgs e)
        {
            /* codigo se ejecuta cuando el usuario hace click en
             * cualquiera de los botones
             */

            // convertir a button el sender

            Button boton = sender as Button;

            switch (boton.Name)
            {
                case "btnCerrar":
                    this.Close();
                    break;
                case "btnConfirmar":
                    Entidades.Autor objEntidadAutor = new Entidades.Autor();
                    objEntidadAutor.Apellido = txtApellido.Text;
                    objEntidadAutor.Nombre = txtNombre.Text;
                    objEntidadAutor.FechaNacimiento = dtpFechaNac.Value;
                    //TODO Falta Pais
                    
                    Logica.Autor objLogicaAutor = new Logica.Autor();
                    objLogicaAutor.Agregar(objEntidadAutor, Program.ListaAutores);
                    MessageBox.Show("AUTOR AGREGADO A LA BASE DE DATOS!!!", "NUEVO AUTOR");
                    break;
                default:
                    break;
            }



        }



    }
}
