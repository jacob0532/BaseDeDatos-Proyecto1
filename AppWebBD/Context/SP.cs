using AppWebBD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AppWebBD.Context
{
    public class SP
    {
        string connectionString = "Data Source=proyectobd.cwzzdv93j6mm.us-east-2.rds.amazonaws.com;Initial Catalog=ProyectoBD1;User ID=Admin;Password= AdminAWS123";
        public IEnumerable<Cliente> SeleccionarClientes()
        {
            var clienteLista = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_SeleccionarClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var cliente = new Cliente();
                    cliente.Nombre = dr["Nombre"].ToString();
                    cliente.ValorDocIdentidad = Convert.ToInt32(dr["ValorDocIdentidad"].ToString());
                    cliente.Email = dr["Email"].ToString();
                    cliente.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    cliente.Telefono1 = Convert.ToInt32(dr["Telefono1"].ToString());
                    cliente.Telefono2 = Convert.ToInt32(dr["Telefono2"].ToString());
                    cliente.TipoDocIdentidadid = Convert.ToInt32(dr["TipoDocIdentidadid"].ToString());

                    clienteLista.Add(cliente);
                }
                con.Close();
            }
            return clienteLista;
        }
        public Cliente SeleccionarClientePorCedula(int? ValorDocIdentidad) //El signo de pregunta sirve para generar un error si el contenido es NULL
        {
            var cliente = new Cliente();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SeleccionarClientePorCedula", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Cedula", ValorDocIdentidad);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cliente.Nombre = dr["Nombre"].ToString();
                    cliente.ValorDocIdentidad = Convert.ToInt32(dr["ValorDocIdentidad"].ToString());
                    cliente.Email = dr["Email"].ToString();
                    cliente.FechaNacimiento = dr["FechaNacimiento"].ToString();
                    cliente.Telefono1 = Convert.ToInt32(dr["Telefono1"].ToString());
                    cliente.Telefono2 = Convert.ToInt32(dr["Telefono2"].ToString());
                    cliente.TipoDocIdentidadid = Convert.ToInt32(dr["TipoDocIdentidadid"].ToString());

                }
                con.Close();
            }
            return cliente;
        }
    }
}
