using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;


namespace ProjectServices.Administrador
{
    class clsAdminCategoria
    {

        ICategoria iCategoria = new MysqlCategoria();


        //Insert
        public Boolean insert(clsCategoria insert)
        {
            try
            {
                return iCategoria.Insert(insert);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema  : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        //Update
        public Boolean update(clsCategoria update)
        {
            try
            {
                return iCategoria.Update(update);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        //Delete
        public Boolean delete(clsCategoria delete)
        {
            try
            {
                return iCategoria.Delete(delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

      
        //lista Categorias
        public DataTable lista_Categoria()
        {

            try
            {
                return iCategoria.lista_Categorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }

        //lista Categoria producto
        public DataTable listaproductocate(clsCategoria categoria)
        {

            try
            {
                return iCategoria.listaproductocate(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

        }

        //Lista categoria - combo
        public List<clsCategoria> list_Categoria()
        {
            try
            {
                return iCategoria.list_Categoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema : " + ex.Message, " ADVERTENCIA !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

    }
}
