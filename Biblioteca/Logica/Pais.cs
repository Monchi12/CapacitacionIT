using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class Pais
    {
        public void agregar(Entidades.Pais pais)
        {
            Datos.Pais.agregar(pais);
        }

        public DataTable traerDatos()
        {
            return Datos.Pais.traerTodos();
        }


    }
}
