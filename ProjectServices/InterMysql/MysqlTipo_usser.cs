using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data.MySqlClient;
using ProjectServices.Class;
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;


namespace ProjectServices.InterMysql
{
    class MysqlTipo_usser:ITipo_usser
    {
        clsConexion con = new clsConexion();
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adap = null;
        DataTable tabla = null;



        //lista_categoria - combo
        public List<clsTipo_usser> List_Tipousser()
        {
            try
            {
                List<clsTipo_usser> comboTipousser = new List<clsTipo_usser>();
                con.conectarBD();
                cmd = new MySqlCommand("lista_tipousser", con.conector);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clsTipo_usser tipo = new clsTipo_usser();
                        tipo.Tipo_usser = dr.GetInt32(0);
                        tipo.Descripcion = dr.GetString(1);
                        comboTipousser.Add(tipo);
                    }
                }

                return comboTipousser;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { con.conector.Dispose(); cmd.Dispose(); con.desconectarBD(); }
        }
    }
}
