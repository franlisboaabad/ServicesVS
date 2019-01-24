using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdmindetallecompra
    {
        IDetallecompra iDCompra = new MysqlDetallecompra();
        //Insert
        public Boolean insert(clsDetallecompra insert)
        {
            try
            {
                return iDCompra.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
