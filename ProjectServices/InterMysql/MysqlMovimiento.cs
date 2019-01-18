using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.Conexion;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjectServices.InterMysql
{
    class MysqlMovimiento : IMovimiento
    {

        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        //insertar movimiento
        public bool Insert(clsMovimiento insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardarmovimiento", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("monto", insert.Monto);
                cmd.Parameters.AddWithValue("tipomovimiento", insert.Movimiento);
                cmd.Parameters.AddWithValue("descripcion", insert.Descripcion);

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

        //modificar movimiento
        public bool Update(clsMovimiento update)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_movimiento", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", update.Codigomovimiento);
                cmd.Parameters.AddWithValue("monto", update.Monto);
                cmd.Parameters.AddWithValue("movimiento", update.Movimiento);
                cmd.Parameters.AddWithValue("descripcion", update.Descripcion);

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




        //Lista de movimientos
        public DataTable lista_Movimientos()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("ListaMovimientos", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { con.conector.Dispose(); cmd.Dispose(); con.desconectarBD(); }
        }


    }
}
