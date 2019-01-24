using MySql.Data.MySqlClient;
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using System.Data;

namespace ProjectServices.InterMysql
{
    class Mysql_Detalle_os_servicio : IDetalle_os_servicio
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        /* Insert detalle _ os _ servicio */
        public bool Insert(clsDetalle_dos_servicio insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardar_DOS_Servicios", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idos", insert.Id_OS);
                cmd.Parameters.AddWithValue("idservice", insert.Id_Service);
                cmd.Parameters.AddWithValue("costo", insert.Costo);


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
