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
    class MysqlProveedor : IProveedor

    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;



        //Insertar  Proveedor
        public bool Insert(clsProveedor insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarProveedor", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ruc", insert.Ruc);
                cmd.Parameters.AddWithValue("razonsocial", insert.Razonsocial);
                cmd.Parameters.AddWithValue("direccion", insert.Direccion);
                cmd.Parameters.AddWithValue("localidad", insert.Localidad);
                cmd.Parameters.AddWithValue("celular", insert.Celular);
                cmd.Parameters.AddWithValue("email", insert.Email);

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

        //Update  Proveedor
        public bool Update(clsProveedor update)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_proveedor", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", update.Codproveedor);
                cmd.Parameters.AddWithValue("ruc", update.Ruc);
                cmd.Parameters.AddWithValue("razonsocial", update.Razonsocial);
                cmd.Parameters.AddWithValue("direccion", update.Direccion);
                cmd.Parameters.AddWithValue("localidad", update.Localidad);
                cmd.Parameters.AddWithValue("celular", update.Celular);
                cmd.Parameters.AddWithValue("email", update.Email);

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

        //Delete  Proveedor
        public bool Delete(clsProveedor delete)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("delete_proveedor", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", delete.Codproveedor);

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

        //Lista proveedor
        public DataTable ListaProveedor()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("lista_Proveedor", con.conector);
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
