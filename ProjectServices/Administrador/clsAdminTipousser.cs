using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using ProjectServices.Class;
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;


namespace ProjectServices.Administrador
{
    class clsAdminTipousser
    {
        ITipo_usser iTipousser = new MysqlTipo_usser();

        //lista tipousser Metrocombo
        public List<clsTipo_usser> list_tipousser()
        {
            try
            {
                return iTipousser.List_Tipousser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
