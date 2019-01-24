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


        /* LoginAdministrador */
        public bool LoginAdministrador(clsUsuario Usuario)
        {

            try
            {
                con.conectarBD();
                clsUsuario Usser = new clsUsuario();
                cmd = new MySqlCommand("LoginAdministrador", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("usser", Usuario.Usuario);
                cmd.Parameters.AddWithValue("contraseña", Usuario.Clave);
                cmd.CommandTimeout = 200;
                int x = Convert.ToInt32(cmd.ExecuteScalar());
                if (x != 0)
                {
                    return true;
                }else
                {
                    return false;
                }

            }

            catch (MySqlException ex) { throw ex; }

            finally { con.conector.Dispose(); cmd.Dispose(); con.desconectarBD(); }
        }

        /*Validar usuario*/
        public clsUsuario Validar_Usuario(string u,string c)
        {
            try
            {
                clsUsuario Usser = new clsUsuario();
                con.conectarBD();
                cmd = new MySqlCommand("LoginAdministrador", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 200;
                cmd.Parameters.AddWithValue("usser",u);
                cmd.Parameters.AddWithValue("contraseña", c);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usser.Id_Trabajador = dr.GetInt32(0);
                        Usser.Usuario = dr.GetString(1);
                        Usser.Clave = dr.GetString(2);
                        Usser.Estado = dr.GetBoolean(3);
                      
                    }

                }

                return Usser;

            }

            catch (MySqlException ex) { throw ex; }

            finally { con.conector.Dispose(); cmd.Dispose(); con.desconectarBD(); }
        }



    }
}
