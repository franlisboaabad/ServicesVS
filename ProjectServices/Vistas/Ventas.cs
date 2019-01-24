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
        clsVenta Venta = new clsVenta();
        clsUsuario Usuario = new clsUsuario();
        clsProducto Cproducto = new clsProducto();
        clsCategoria Ccategoria;

        clsAdminCategoria AdmCategoria = new clsAdminCategoria();
        

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Ventas(clsUsuario Usser)
        {
            InitializeComponent();
            CategoriaCombo();
            MostrarDocumentos();
            GridaProductos.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            GridaVentas.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.Width = 1280;

            Usuario = Usser;
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
            GridaVentas.RowTemplate.Height = 40;
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

      
     

        private void GridaVentas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int j = GridaVentas.Rows.Count;

                    if (j > 0)
                    {

                        int x = GridaVentas.CurrentRow.Index;

                        GridaVentas.Rows.RemoveAt(x);
                        ImportetotalProductos();
                    }
                    
                    
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportetotalProductos()
        {
            Double total = 0;

            if (GridaVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridaVentas.Rows)
                {
                    total += Convert.ToDouble(row.Cells["SUB_TOTAL"].Value);
                }
            }

            labelImporte.Text = Convert.ToString(total);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int j = GridaVentas.Rows.Count;

                if (j > 0)
                {
                    if (Application.OpenForms["MetododePago"] != null)
                    {
                        Application.OpenForms["MetododePago"].Activate();
                    }
                    else
                    {
                        
                        MPagoventa form = new MPagoventa(Usuario);
                        form.midata = GridaVentas;
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

        private void btnNuevi_Click(object sender, EventArgs e)
        {
            try
            {
                GridaVentas.Rows.Clear();
                labelImporte.Text = "00.00";
                GridaProductos.ClearSelection();
                CategoriaCombo();
                txtcantidad.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnproductos_Click_1(object sender, EventArgs e)
        {
            try
            {
                int j = (int)GridaProductos.SelectedRows.Count;

                if (j != 0)
                {
                    int existencias = (int)GridaProductos.CurrentRow.Cells[6].Value;
                    int cantidad = Int32.Parse(txtcantidad.Text);

                    if (txtcantidad.Text != string.Empty)
                    {
                        int filaventas = GridaVentas.Rows.Count;

                        if (cantidad < existencias)
                        {
                            GridaVentas.Rows.Add();
                            GridaVentas.Rows[filaventas].Cells[0].Value = GridaProductos.CurrentRow.Cells[2].Value.ToString() + " " + GridaProductos.CurrentRow.Cells[3].Value.ToString();
                            GridaVentas.Rows[filaventas].Cells[1].Value = Int32.Parse(txtcantidad.Text);
                            GridaVentas.Rows[filaventas].Cells[2].Value = GridaProductos.CurrentRow.Cells[5].Value.ToString();
                            GridaVentas.Rows[filaventas].Cells[4].Value = GridaProductos.CurrentRow.Cells[0].Value.ToString();

                            double pventa = Double.Parse(GridaProductos.CurrentRow.Cells[5].Value.ToString());
                            cantidad = Int32.Parse(txtcantidad.Text);
                            double subtotal = cantidad * pventa;
                            GridaVentas.Rows[filaventas].Cells[3].Value = subtotal;
                            ImportetotalProductos();
                        }
                        else { MessageBox.Show("Ingresar una cantidad menor que el stok del producto \n" + " " + "Stok : " + existencias, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else
                    {
                        MessageBox.Show("Ingresar cantidad de productos  ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtcantidad.Select();
                    }

                }
                else { MessageBox.Show("Debe seleccionar un producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
