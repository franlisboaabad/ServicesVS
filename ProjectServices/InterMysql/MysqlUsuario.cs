using MySql.Data.MySqlClient;
using ProjectServices.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.Conexion;
using ProjectServices.Class;


namespace ProjectServices.InterMysql
{
    class MysqlUsuario : IUsuario
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;


        //Insertar  Trabajador Usuario
        public bool Insert(clsUsuario insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarTrabajador", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", insert.Nombre);
                cmd.Parameters.AddWithValue("ape", insert.Apellidos);
                cmd.Parameters.AddWithValue("sex", insert.Sexo);
                cmd.Parameters.AddWithValue("fnac", insert.Fecha_nacimiento);
                cmd.Parameters.AddWithValue("doc", insert.Documento);
                cmd.Parameters.AddWithValue("dir", insert.Direccion);
                cmd.Parameters.AddWithValue("cel", insert.Celular);
                cmd.Parameters.AddWithValue("ema", insert.Email);
                cmd.Parameters.AddWithValue("usser", insert.Usuario);
                cmd.Parameters.AddWithValue("pass", insert.Clave);

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

        //Update  Trabajador Usuario
        public bool Update(clsUsuario update)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_trabajador", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", update.Nombre);
                cmd.Parameters.AddWithValue("ape", update.Apellidos);
                cmd.Parameters.AddWithValue("sex", update.Sexo);
                cmd.Parameters.AddWithValue("fnac", update.Fecha_nacimiento);
                cmd.Parameters.AddWithValue("doc", update.Documento);
                cmd.Parameters.AddWithValue("dir", update.Direccion);
                cmd.Parameters.AddWithValue("cel", update.Celular);
                cmd.Parameters.AddWithValue("ema", update.Email);
                cmd.Parameters.AddWithValue("usser", update.Usuario);
                cmd.Parameters.AddWithValue("pass", update.Clave);
                cmd.Parameters.AddWithValue("codigo", update.Id_Trabajador);

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

        //Delete  Trabajador Usuario
        public bool Delete(clsUsuario delete)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("delete_trabajador", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", delete.Id_Trabajador);

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

        //Listar Trabajador Usuario 

        public DataTable lista_Usuario()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("lista_Trabajador", con.conector);
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
