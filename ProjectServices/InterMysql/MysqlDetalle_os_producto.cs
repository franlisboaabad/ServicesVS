using MySql.Data.MySqlClient;
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using System.Data;

namespace ProjectServices.InterMysql
{
    class MysqlDetalle_os_producto : IDetalle_os_producto
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;
        
        /* Insert detalle_os_producto */
        public bool Insert(clsDetalle_dos_producto insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardar_DOS_Productos", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idos", insert.Id_OS);
                cmd.Parameters.AddWithValue("idproducto", insert.Id_producto);
                cmd.Parameters.AddWithValue("cantidad", insert.Cantidad);
                cmd.Parameters.AddWithValue("pventa", insert.Costo);
                cmd.Parameters.AddWithValue("itotal", insert.Importe_total);


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
