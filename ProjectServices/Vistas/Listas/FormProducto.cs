using ProjectServices.Administrador;
using ProjectServices.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormProducto : MetroFramework.Forms.MetroForm
    {

        clsVenta Venta = new clsVenta();
        clsUsuario Usuario = new clsUsuario();
        clsProducto Cproducto = new clsProducto();
        clsCategoria Ccategoria;

        public clsProducto Product;

        clsAdminCategoria AdmCategoria = new clsAdminCategoria();


        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public FormProducto()
        {
            InitializeComponent();
            CategoriaCombo();
            MostrarDocumentos();
            txtcantidad.Focus();
            dataproductos.DefaultCellStyle.Font = new Font("Century Gothic", 11);
        
        }

        private void MostrarDocumentos()
        {



            dataproductos.Columns[1].Width = 150;
            dataproductos.Columns[2].Width = 150;
            dataproductos.Columns[3].Width = 150;
            dataproductos.Columns[4].Width = 250;

            dataproductos.Columns[0].Visible = false;
            dataproductos.Columns[5].Visible = false;


            dataproductos.RowTemplate.Height = 40;
        }
        private void CategoriaCombo()
        {
            /*Lista categoria en combobox*/
            try
            {
                metroComboBox1.DataSource = AdmCategoria.list_Categoria();
                metroComboBox1.DisplayMember = "Nombre";
                metroComboBox1.ValueMember = "Id_Categoria";
                metroComboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message + " -- Posiblemente no cuenta con categorias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Ccategoria = new clsCategoria();

                string c = ((clsCategoria)metroComboBox1.SelectedItem).Nombre;
                //MessageBox.Show(c);

                Ccategoria.Nombre = c;


                dt = AdmCategoria.listaproductocate(Ccategoria);
                ds.Tables.Add(dt);
                dataproductos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Product = new clsProducto();

                if (txtcantidad.Text.Equals(""))
                {
                    MessageBox.Show("Debe ingresar la cantidad del producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcantidad.Focus();
                }
                else
                {  
                    if (MessageBox.Show("¿ Desea agregar el producto seleccionado ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       
                        Product.Codproducto = Int32.Parse(dataproductos.CurrentRow.Cells[0].Value.ToString());
                        Product.Nombre = dataproductos.CurrentRow.Cells[2].Value.ToString() + " " + dataproductos.CurrentRow.Cells[3].Value.ToString();
                        Product.Cantidad = Int32.Parse(txtcantidad.Text);
                        Product.Precioventa = Double.Parse(dataproductos.CurrentRow.Cells[5].Value.ToString());

                        Product.Subtotal = Product.Cantidad * Product.Precioventa;

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error del sistema ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
