using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Autor
    {
        //Propiedades
        public int ID { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Pais Pais { get; set; }

    }
}
