using System;

using System.Data;
using MySql.Data.MySqlClient;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.Conexion;


namespace ProjectServices.InterMysql
{
    class MysqlDetallecompra : IDetallecompra
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;


        //Insertar  detalleventa
        public bool Insert(clsDetallecompra insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardardetalle_compra", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idcompra", insert.Id_compra);
                cmd.Parameters.AddWithValue("idproducto", insert.Id_producto);
                cmd.Parameters.AddWithValue("cantidad", insert.Cantidad);
                cmd.Parameters.AddWithValue("precio_compra", insert.Precio_compra);
                cmd.Parameters.AddWithValue("importe_total", insert.Importe_total);


                int resultado = cmd.ExecuteNonQuery();

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
