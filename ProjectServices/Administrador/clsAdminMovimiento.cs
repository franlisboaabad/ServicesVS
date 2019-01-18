using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System.Data;

namespace ProjectServices.Administrador
{
    class clsAdminMovimiento
    {

        IMovimiento iMovimiento = new MysqlMovimiento();


        //Insert
        public Boolean insert(clsMovimiento insert)
        {
            try
            {
                return iMovimiento.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public Boolean update(clsMovimiento update)
        {
            try
            {
                return iMovimiento.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //lista Categorias
        public DataTable lista_Movimientos()
        {
            try
            {
                return iMovimiento.lista_Movimientos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

    }
}
