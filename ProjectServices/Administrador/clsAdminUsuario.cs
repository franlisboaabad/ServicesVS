using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Interfaces;
using ProjectServices.Entidades;
using ProjectServices.InterMysql;
using System.Windows.Forms;
using System.Data;

namespace ProjectServices.Administrador
{
    class clsAdminUsuario
    {

        IUsuario iTrabajador = new MysqlUsuario();

        //Insert
        public Boolean insert(clsUsuario insert)
        {
            try
            {
                return iTrabajador.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Update
        public Boolean update(clsUsuario update)
        {
            try
            {
                return iTrabajador.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //Delete
        public Boolean delete(clsUsuario delete)
        {
            try
            {
                return iTrabajador.Delete(delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        //lista - Trabajador Usuario - 
        public DataTable lista_Usuarios()
        {

            try
            {
                return iTrabajador.lista_Usuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }


    }
}
