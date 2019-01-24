using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdmindetalleventa
    {

        IDetalleventa iDetalleventa = new MysqlDetalleventa();

        //Insert
        public Boolean insert(clsDetalleventa insert)
        {
            try
            {
                return iDetalleventa.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


    }
}
