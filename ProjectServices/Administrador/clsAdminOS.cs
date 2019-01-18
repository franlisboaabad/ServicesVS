using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdminOS
    {
        IOrdenS iOrden = new MysqlOS();

        //Insert
        public Boolean insert(clsOrdenservicio insert)
        {
            try
            {
                return iOrden.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
