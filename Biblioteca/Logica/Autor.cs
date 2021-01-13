using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Autor
    {
        //Metodos

        public void Agregar(Entidades.Autor autor,List<Entidades.Autor> lista)
        {
            // TODO modificar cuando accedamos a sql server
            autor.ID = lista.Count + 1;
            lista.Add(autor);
        }

        public List<Entidades.Autor> traer(string pais, Entidades.Autor autor, List<Entidades.Autor> lista)
        {

            List<Entidades.Autor> listaFiltrada = new List<Entidades.Autor>();
            foreach (var item in lista)
            {
                if (item.Pais.ID == pais)
                {
                    listaFiltrada.Add(item);
                }
            }
            return listaFiltrada;

        }


    }
}
