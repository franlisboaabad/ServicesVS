using MySql.Data.MySqlClient;
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.InterMysql
{
    class MysqlServicio : IServicio
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        //Insertar  servicio
        public bool Insert(clsServicio insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Guardarservicio", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("servicio", insert.Servicio);
                cmd.Parameters.AddWithValue("costo", insert.Costo);
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

        //Update  servicio
        public bool Update(clsServicio update)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_servicio", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", update.CodigoServicio);
                cmd.Parameters.AddWithValue("servicio", update.Servicio);
                cmd.Parameters.AddWithValue("costo", update.Costo);
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

        //Delete  Servicio
        public bool Delete(clsServicio delete)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("delete_servicio", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", delete.CodigoServicio);

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


        //Lista de Servicios
        public DataTable lista_servicios()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("lista_servicios", con.conector);
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
