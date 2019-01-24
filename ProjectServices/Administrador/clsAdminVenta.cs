using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdminVenta
    {
        IVenta iVenta = new MysqlVenta();


        //Insert
        public Boolean insert(clsVenta insert)
        {
            try
            {
                return iVenta.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
