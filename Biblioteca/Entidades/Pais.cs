using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pais
    {
        public int ID { get; set; }
        public string Nombre { set; get; }
        public List<Entidades.Autor> Autores { get; set; }
    }
}
