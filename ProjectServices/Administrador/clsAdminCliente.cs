using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectServices.Administrador
{
    class clsAdminCliente
    {
        ICliente iCliente = new MysqlCliente();

        //Insert
        public Boolean insert(clsCliente insert)
        {
            try
            {
                return iCliente.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Actualizar
        public Boolean update(clsCliente update)
        {
            try
            {
                return iCliente.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Eliminar
        public Boolean delete(clsCliente delete)
        {
            try
            {
                return iCliente.Delete(delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //lista Clientes
        public DataTable lista_clientes()
        {

            try
            {
                return iCliente.lista_cliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }
    }
}
