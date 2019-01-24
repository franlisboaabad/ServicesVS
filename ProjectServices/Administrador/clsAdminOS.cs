using System;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using System.Windows.Forms;
using System.Data;

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

        //Anular
        public Boolean Anular_ordenservicio(int codigo)
        {
            try
            {
                return iOrden.Anular_ordenservicio(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }



        //lista Ordenes de servicio, nombre o apellidos
        public DataTable Lista_ordenservicio(string nombre,string apellidos)
        {

            try
            {
                return iOrden.Lista_ordenservicio(nombre,apellidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }

        //lista Ordenes de servicio, todas
        public DataTable Listar_ordenservicio()
        {

            try
            {
                return iOrden.Listar_ordenservicio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }


        //lista Ordenes de servicio, todas
        public DataTable Listar_ordenes_pendientes()
        {

            try
            {
                return iOrden.Listar_ordenes_pendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema : " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }



    }
}
