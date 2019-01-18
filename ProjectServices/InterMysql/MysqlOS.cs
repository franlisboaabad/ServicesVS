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
                cmd.Parameters.AddWithValue("diagnosticotecnico", insert.Diagnostico);
                cmd.Parameters.AddWithValue("estado", insert.Estado);

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
    }
}
