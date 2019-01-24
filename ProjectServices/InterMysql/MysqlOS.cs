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
    class MysqlOS : IOrdenS
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;

        //Insertar  OS
        public bool Insert(clsOrdenservicio insert)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("GuardarOS", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter parmetro;

                cmd.Parameters.AddWithValue("idcliente", insert.Id_cliente);
                cmd.Parameters.AddWithValue("idtecnico", insert.Id_tecnico);
                cmd.Parameters.AddWithValue("estadoservicio", insert.Estadoservicio);
                cmd.Parameters.AddWithValue("fechainicial", insert.Fechainicial);
                cmd.Parameters.AddWithValue("fechafinal", insert.Fechafinal);
                cmd.Parameters.AddWithValue("garantia", insert.Garantia);
                cmd.Parameters.AddWithValue("descripcionproducto", insert.DescripcionProducto);
                cmd.Parameters.AddWithValue("observaciones", insert.Observaciones);
                cmd.Parameters.AddWithValue("diagnostico", insert.Diagnostico);
                cmd.Parameters.AddWithValue("importe_total", insert.Importe_total);
                cmd.Parameters.AddWithValue("tipopago", insert.Tipo_pago);
                cmd.Parameters.AddWithValue("pago", insert.Pago);
                cmd.Parameters.AddWithValue("vuelto", insert.Vuelto);
                cmd.Parameters.AddWithValue("saldo", insert.Saldo);
                
                parmetro = cmd.Parameters.AddWithValue("newid", 0);
                parmetro.Direction = ParameterDirection.Output;

                int resultado = cmd.ExecuteNonQuery();

                insert.Id_OS = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        /*Buscar orden de servicio por nombre o apellidos */
        public DataTable Lista_ordenservicio(string nombre,string apellidos)
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("Buscarordenservicio", con.conector);
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("apellidos",apellidos);
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


        /*Listar mis ordenes de servicio */
        public DataTable Listar_ordenservicio()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("Listar_ordenservicio", con.conector);
                
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

        /*Listar mis ordenes de servicio pendientes*/
        public DataTable Listar_ordenes_pendientes()
        {
            try
            {
                tabla = new DataTable();
                con.conectarBD();
                cmd = new MySqlCommand("Listar_ordenes_pendientes", con.conector);

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


        //Anular  OS
        public bool Anular_ordenservicio(int codigo)
        {

            try
            {
                con.conectarBD();

                cmd = new MySqlCommand("Anular_ordenservicio", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("codigo", codigo);
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
