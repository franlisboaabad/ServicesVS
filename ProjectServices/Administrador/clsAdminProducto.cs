using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System.Windows.Forms;
using System.Data;

namespace ProjectServices.Administrador
{
    
    class clsAdminProducto
    {
        IProducto iproducto = new MysqlProducto();

        //Insert
        public Boolean insert(clsProducto insert)
        {
            try
            {
                return iproducto.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        //Update
        public Boolean update(clsProducto update)
        {
            try
            {
                return iproducto.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Delete
        public Boolean Delete(clsProducto delete)
        {
            try
            {
                return iproducto.Delete(delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Lista de Productos
        public DataTable lista_Productos()
        {

            try
            {
                return iproducto.ListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }
    }
}
