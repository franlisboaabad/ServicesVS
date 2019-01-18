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

    class MysqlProducto : IProducto
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        clsValidacion validacion = new clsValidacion();


        public bool Insert(clsProducto insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarProducto", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nombre", insert.Nombre);
                cmd.Parameters.AddWithValue("marca", insert.Marca);
                cmd.Parameters.AddWithValue("modelo", insert.Modelo);
                cmd.Parameters.AddWithValue("existencias", insert.Existencias);
                cmd.Parameters.AddWithValue("descripcion", insert.Descripcion);
                cmd.Parameters.AddWithValue("idcategoria", insert.Codcategoria);
                cmd.Parameters.AddWithValue("precioventa", insert.Precioventa);
                cmd.Parameters.AddWithValue("img", insert.Imagen);

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


        //Update  Producto
        public bool Update(clsProducto update)
        {
            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("update_producto", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nombre", update.Nombre);
                cmd.Parameters.AddWithValue("marca", update.Marca);
                cmd.Parameters.AddWithValue("modelo", update.Modelo);
                cmd.Parameters.AddWithValue("existencias", update.Existencias);
                cmd.Parameters.AddWithValue("descripcion", update.Descripcion);
                cmd.Parameters.AddWithValue("idcategoria", update.Codcategoria);
                cmd.Parameters.AddWithValue("precioventa", update.Precioventa);
                cmd.Parameters.AddWithValue("imagen", update.Imagen);
                cmd.Parameters.AddWithValue("codproducto", update.Codproducto);


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

        //Delete  Producto
        public bool Delete(clsProducto delete)
        {
            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("delete_producto", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", delete.Codproducto);

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


        //Lista de productos - gridpanel - Inventario
        public DataTable ListaProductos()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("lista_Productos", con.conector);
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
