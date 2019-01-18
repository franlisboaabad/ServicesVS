using ProjectServices.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectServices.Entidades;

namespace ProjectServices.Vistas
{
    public partial class Ventas : Form
    {
        clsAdminCategoria AdmCategoria = new clsAdminCategoria();
        clsProducto Cproducto = new clsProducto();
        clsCategoria Ccategoria;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Ventas()
        {
            InitializeComponent();

            CategoriaCombo();
            
        }

        private void CategoriaCombo()
        {
            /*Lista categoria en combobox*/
            try
            {
                metroComboBox1.DataSource = AdmCategoria.list_Categoria();
                metroComboBox1.DisplayMember = "Nombre";
                metroComboBox1.ValueMember = "Id_Categoria";
                metroComboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message + " -- Posiblemente no cuenta con categorias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
