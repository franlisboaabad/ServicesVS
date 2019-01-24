using MySql.Data.MySqlClient;
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using System.Data;

namespace ProjectServices.InterMysql
{
    class MysqlDetalleventa : IDetalleventa
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;


        //Insertar  detalleventa
        public bool Insert(clsDetalleventa insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardardetalle_venta", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idventa", insert.Id_venta);
                cmd.Parameters.AddWithValue("idproducto", insert.Id_producto);
                cmd.Parameters.AddWithValue("cantidad", insert.Cantidad);
                cmd.Parameters.AddWithValue("precio_venta", insert.Precio_venta);
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
