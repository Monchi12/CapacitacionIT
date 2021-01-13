using System;
using System.Collections.Generic;
using System.Text;
using System.Data; // para acceso a datos generico
using System.Data.SqlClient;

namespace Datos
{
   public class Autor
    {
        
        //Metodos de manipulacion de datos
        public static void Agregrar (Entidades.Autor autor)
        {
            // sentencia a ejecutar
            string strSQL = @"Insert into Autores(apellido,nombre,fechaNacimiento,idMacionalidad)
                              values (@apellido,@nombre,@fechaNacimiento,@nacionalidad)";

            // objeto de conexion
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objConexion);

            // parametros
            objCom.Parameters.AddWithValue("@apellido", autor.Apellido);
            objCom.Parameters.AddWithValue("@nombre", autor.Nombre);
            objCom.Parameters.AddWithValue("@fechaNacimiento", autor.FechaNacimiento);
            objCom.Parameters.AddWithValue("@nacionalidad", autor.Pais.ID);

            // abrir la conexion
            objConexion.Open();

            // ejecutar la sentencia
            objCom.ExecuteNonQuery(); // ejecuto el insert sincronico

            // cerrar la conexion
            objConexion.Close();

        }


    }
}
