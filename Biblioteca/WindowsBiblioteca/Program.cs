using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    static class Program
    {

        public static List<Entidades.Autor> ListaAutores = new List<Entidades.Autor>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }
}
