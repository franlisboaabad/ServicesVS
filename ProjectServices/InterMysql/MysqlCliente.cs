using MySql.Data.MySqlClient;
using ProjectServices.Class;
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
    class MysqlCliente : ICliente
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        clsValidacion validacion = new clsValidacion();

        //Insertar  Cliente
        public bool Insert(clsCliente insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarCliente", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", insert.Nombre);
                cmd.Parameters.AddWithValue("apell", insert.Apellidos);
                cmd.Parameters.AddWithValue("sex", insert.Sexo);
                cmd.Parameters.AddWithValue("t_document", insert.Tipo_documento);
                cmd.Parameters.AddWithValue("document", insert.Documento);
                cmd.Parameters.AddWithValue("dire", insert.Direccion);
                cmd.Parameters.AddWithValue("cel", insert.Celular);
                cmd.Parameters.AddWithValue("ema", insert.Email);

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

        //Actualizar cliente    
        public bool Update(clsCliente update)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_cliente", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", update.Nombre);
                cmd.Parameters.AddWithValue("apell", update.Apellidos);
                cmd.Parameters.AddWithValue("sex", update.Sexo);
                cmd.Parameters.AddWithValue("t_document", update.Tipo_documento);
                cmd.Parameters.AddWithValue("document", update.Documento);
                cmd.Parameters.AddWithValue("dire", update.Direccion);
                cmd.Parameters.AddWithValue("cel", update.Celular);
                cmd.Parameters.AddWithValue("ema", update.Email);
                cmd.Parameters.AddWithValue("codigo", update.Id_Cliente);

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

        //Eliminar Cliente
        public bool Delete(clsCliente delete)
        {
            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("delete_cliente", con.conector);
                cmd.Parameters.AddWithValue("codigo", delete.Id_Cliente);
                cmd.CommandType = CommandType.StoredProcedure;


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

        public DataTable lista_cliente()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("lista_Clientes", con.conector);
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
