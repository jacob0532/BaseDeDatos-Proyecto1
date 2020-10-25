using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PruebaConexion
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
           try
           {
               cn = new SqlConnection("Data Source=proyectobd.cwzzdv93j6mm.us-east-2.rds.amazonaws.com;Initial Catalog=ProyectoBD1;User ID=Admin;Password= AdminAWS123"); 
               cn.Open();
               MessageBox.Show("Conectado");

           }
            catch(Exception ex)
           {
               MessageBox.Show("No se conecto con la base de datos: "+ex.ToString());
           }
        }

        public string insertar(int id,string nombre)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Insert into TipoDocIdentidad(Id,Nombre) values("+id+",'"+nombre+"')",cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

       

        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Persona where Id="+id+"", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: "+ex.ToString());
            }
            return contador;
        }



    }
}
