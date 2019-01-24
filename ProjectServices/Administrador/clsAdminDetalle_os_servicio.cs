using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;

namespace ProjectServices.Administrador
{
    class clsAdminDetalle_os_servicio
    {
        IDetalle_os_servicio iDetalle_os_servicio = new Mysql_Detalle_os_servicio();


        //Insert
        public Boolean insert(clsDetalle_dos_servicio insert)
        {
            try
            {
                return iDetalle_os_servicio.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }



    }
}
