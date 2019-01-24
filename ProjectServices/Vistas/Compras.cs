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

namespace ProjectServices.Vistas
{
    public partial class Compras : Form
    {
        clsVenta Venta = new clsVenta();
        clsUsuario Usuario = new clsUsuario();
        clsProducto Cproducto = new clsProducto();
        clsCategoria Ccategoria;

        clsAdminCategoria AdmCategoria = new clsAdminCategoria();


        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();



        public Compras(clsUsuario Usser)
        {
            InitializeComponent();

            this.Width = 1280;
         
            Usuario = Usser;
            GridaProductos.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            GridaCompras.DefaultCellStyle.Font = new Font("Century Gothic", 11);

            CategoriaCombo();
            MostrarDocumentos();
        }

        private void MostrarDocumentos()
        {
            GridaProductos.Columns[1].Width = 150;
            GridaProductos.Columns[2].Width = 150;
            GridaProductos.Columns[3].Width = 150;
            GridaProductos.Columns[4].Width = 250;

            GridaProductos.Columns[0].Visible = false;
            GridaProductos.Columns[5].Visible = false;

            GridaProductos.RowTemplate.Height = 40;
            GridaCompras.RowTemplate.Height = 40;
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

      
        private void Nuevacompra()
        {
            try
            {
                GridaCompras.Rows.Clear();
                GridaCompras.ClearSelection();
                labelImporte.Text = "00.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtcodigoproveedor_TextChanged(object sender, EventArgs e)
        {
            {/*codigo para proveedor*/ }
        }
        

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Ccategoria = new clsCategoria();

                string c = ((clsCategoria)metroComboBox1.SelectedItem).Nombre;
                //MessageBox.Show(c);

                Ccategoria.Nombre = c;


                dt = AdmCategoria.listaproductocate(Ccategoria);
                ds.Tables.Add(dt);
                GridaProductos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            try
            {
                int j = (int)GridaProductos.SelectedRows.Count;

                if (j != 0)
                {

                    if (txtcantidad.Text == string.Empty)
                    {
                        MessageBox.Show("Ingresar la cantidad del producto a comprar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtcantidad.Focus();
                    }else if (txtpcompra.Text == string.Empty)
                    {
                        MessageBox.Show("Ingresar el prceio de compra del producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtpcompra.Focus();
                    }
                    else
                    {
                        int existencias = (int)GridaProductos.CurrentRow.Cells[6].Value;
                        int cantidad = Int32.Parse(txtcantidad.Text);
                        double pcompra = double.Parse(txtpcompra.Text);
                        int filaventas = GridaCompras.Rows.Count;

                        if (cantidad > 0)
                        {
                            GridaCompras.Rows.Add();
                            GridaCompras.Rows[filaventas].Cells[0].Value = GridaProductos.CurrentRow.Cells[2].Value.ToString() + " " + GridaProductos.CurrentRow.Cells[3].Value.ToString();
                            GridaCompras.Rows[filaventas].Cells[1].Value = Int32.Parse(txtcantidad.Text);
                            GridaCompras.Rows[filaventas].Cells[2].Value = pcompra;
                            GridaCompras.Rows[filaventas].Cells[4].Value = GridaProductos.CurrentRow.Cells[0].Value.ToString();

                            cantidad = Int32.Parse(txtcantidad.Text);
                            double subtotal = cantidad * pcompra;
                            GridaCompras.Rows[filaventas].Cells[3].Value = subtotal;
                            ImportetotalProductos();

                            txtcantidad.Clear();
                            txtpcompra.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar la cantidad del producto a comprar" + existencias, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else { MessageBox.Show("Debe seleccionar un producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportetotalProductos()
        {
            Double total = 0;

            if (GridaCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridaCompras.Rows)
                {
                    total += Convert.ToDouble(row.Cells["SUB_TOTAL"].Value);
                }
            }

            labelImporte.Text = Convert.ToString(total);
        }

        private void btnNuevi_Click(object sender, EventArgs e)
        {
            try
            {
                Nuevacompra();
                CategoriaCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int j = GridaCompras.Rows.Count;

                if (j > 0)
                {
                    if (Application.OpenForms["MetododePago"] != null)
                    {
                        Application.OpenForms["MetododePago"].Activate();
                    }
                    else
                    {

                        MPagocompra form = new MPagocompra(Usuario);
                        form.midata = GridaCompras;
                        form.labelmonto.Text = labelImporte.Text;
                        form.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber productos para generar una venta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
