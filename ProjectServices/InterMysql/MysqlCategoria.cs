using System;
using System.Collections.Generic;
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
    class MysqlCategoria : ICategoria
    {

        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;


        clsValidacion validacion = new clsValidacion();

        public bool Insert(clsCategoria insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarCategoria", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nombre", insert.Nombre);
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


        //Actualizar categoria
        public bool Update(clsCategoria update)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_categoria", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", update.Nombre);
                cmd.Parameters.AddWithValue("des", update.Descripcion);
                cmd.Parameters.AddWithValue("idcate", update.Id_Categoria);


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


        public bool Delete(clsCategoria delete)
        {
            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("delete_categoria", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idcate", delete.Id_Categoria);


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


        //Lista de categoria
        public DataTable lista_Categorias()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("lista_Categorias", con.conector);
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


        /* Lista producto por categoria*/

        public DataTable listaproductocate(clsCategoria categoria)
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("Listaproductocategoria", con.conector);
                cmd.Parameters.AddWithValue("ncategoria", categoria.Nombre);
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

        //lista_categoria - combo
        public List<clsCategoria> list_Categoria()
        {
            try
            {
                List<clsCategoria> comboCategoria = new List<clsCategoria>();
                con.conectarBD();
                cmd = new MySqlCommand("lista_Categorias", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clsCategoria Categoria = new clsCategoria();
                        Categoria.Id_Categoria = dr.GetInt32(0);
                        Categoria.Nombre = dr.GetString(1);
                        comboCategoria.Add(Categoria);
                    }
                }

                return comboCategoria;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.conector.Dispose(); cmd.Dispose(); con.desconectarBD(); }
        }
    }
}
