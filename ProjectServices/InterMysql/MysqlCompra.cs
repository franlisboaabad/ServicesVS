using System;

using System.Data;
using MySql.Data.MySqlClient;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.Conexion;

namespace ProjectServices.InterMysql
{
    class MysqlCompra : ICompra
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        /* Registrar compra */
        public bool Insert(clsCompra insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardarcompra", con.conector);
                MySqlParameter parmetro;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id_proveedor", insert.Id_proveedor);
                cmd.Parameters.AddWithValue("id_usuario", insert.Id_usuario);
                cmd.Parameters.AddWithValue("itotal", insert.Importe_total);
                cmd.Parameters.AddWithValue("tipo_pago", insert.Tipo_pago);
                cmd.Parameters.AddWithValue("pago", insert.Pago);
                cmd.Parameters.AddWithValue("saldo", insert.Saldo);
                cmd.Parameters.AddWithValue("documento", insert.Documento);
                cmd.Parameters.AddWithValue("numero_documento", insert.Numero_documento);
                cmd.Parameters.AddWithValue("fecha", insert.Fecha_registro);

                parmetro = cmd.Parameters.AddWithValue("newid", 0);
                parmetro.Direction = ParameterDirection.Output;

                int resultado = cmd.ExecuteNonQuery();

                insert.Id_compra = Convert.ToInt32(cmd.Parameters["newid"].Value);

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
