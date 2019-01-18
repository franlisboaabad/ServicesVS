using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdminServicio 
    {
        IServicio iServicio = new MysqlServicio();

        //Insert
        public Boolean insert(clsServicio insert)
        {
            try
            {
                return iServicio.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Update
        public Boolean update(clsServicio update)
        {
            try
            {
             return iServicio.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        //Delete
        public Boolean delete(clsServicio delete)
        {
            try
            {
                return iServicio.Delete(delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        //lista Servicios
        public DataTable lista_Servicio()
        {

            try
            {
                return iServicio.lista_servicios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }
    }
}
