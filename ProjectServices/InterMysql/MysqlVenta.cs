using System;

using System.Data;
using MySql.Data.MySqlClient;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.Conexion;



namespace ProjectServices.InterMysql
{
    class MysqlVenta : IVenta
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        /* Registrar venta */
        public bool Insert(clsVenta insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarVenta", con.conector);
                MySqlParameter parmetro;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idvendedor", insert.Id_vendedor);
                cmd.Parameters.AddWithValue("idcliente", insert.Id_cliente);
                cmd.Parameters.AddWithValue("fecha_registro", insert.Fecha_registro);
                cmd.Parameters.AddWithValue("importe_total", insert.Importe_total);
                cmd.Parameters.AddWithValue("pago", insert.Pago);
                cmd.Parameters.AddWithValue("vuelto", insert.Vuelto);

                parmetro = cmd.Parameters.AddWithValue("newid", 0);
                parmetro.Direction = ParameterDirection.Output;

                int resultado = cmd.ExecuteNonQuery();

                insert.Id_venta = Convert.ToInt32(cmd.Parameters["newid"].Value);

                if (resultado != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

            catch (MySqlException ex) { throw ex; }

            finally { con.conector.Dispose(); cmd.Dispose(); con.desconectarBD(); }
        }

    }
}
