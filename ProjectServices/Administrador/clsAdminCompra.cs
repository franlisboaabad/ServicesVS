using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdminCompra
    {
        ICompra iCompra = new MysqlCompra();

        //Insert
        public Boolean insert(clsCompra insert)
        {
            try
            {
                return iCompra.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
