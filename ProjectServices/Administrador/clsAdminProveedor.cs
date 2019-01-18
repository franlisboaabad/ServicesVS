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
    class clsAdminProveedor
    {
        IProveedor iProveedor = new MysqlProveedor();

        //Insert
        public Boolean insert(clsProveedor insert)
        {
            try
            {
                return iProveedor.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Update
        public Boolean update(clsProveedor update)
        {
            try
            {
                return iProveedor.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Delete
        public Boolean delete(clsProveedor delete)
        {
            try
            {
                return iProveedor.Delete(delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public DataTable lista_Proveedor()
        {

            try
            {
                return iProveedor.ListaProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }
    }
}
