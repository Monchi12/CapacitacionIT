using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class Pais
    {
        //metodos
        //agregar un pais
        //Metodo desconectado
        public static void agregar(Entidades.Pais pais)
        {
            string strSQL = "Insert Pises(nombre) values (@nombre)";

            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand objCom = new SqlCommand(strSQL, objConexion);

            objCom.Parameters.AddWithValue("@nombre",pais.Nombre);

            // abrir la conexion
            objConexion.Open();

            // ejecutar la sentencia
            objCom.ExecuteNonQuery(); // ejecuto el insert sincronico

            // cerrar la conexion
            objConexion.Close();

        }

        //traer un pais
        //metodo desconectado
        public static DataTable traerTodos()
        {
            DataTable dt = new DataTable();
            string strSQL = "Select * from Paises";
            SqlDataAdapter objDa = new SqlDataAdapter(strSQL, Conexion.strConexion);
            objDa.Fill(dt);


            return dt;
        }

    }
}
