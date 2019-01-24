using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;

namespace ProjectServices.Administrador
{
    class clsAdminDetalle_os_producto
    {
        IDetalle_os_producto iDetalle_os_producto = new MysqlDetalle_os_producto();

        //Insert
        public Boolean insert(clsDetalle_dos_producto insert)
        {
            try
            {
                return iDetalle_os_producto.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

    }
}
