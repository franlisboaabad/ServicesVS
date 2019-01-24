using ProjectServices.Administrador;
using ProjectServices.Entidades;
using ProjectServices.Vistas.Listas;
using System;
using System.Windows.Forms;

namespace ProjectServices.Vistas
{
    public partial class MPagocompra : MetroFramework.Forms.MetroForm
    {
        clsUsuario Usser;
        clsProveedor Miproveedor;
        public clsCompra Micompra = new clsCompra();
        clsAdminCompra Mysqlcompra = new clsAdminCompra();
        clsAdmindetallecompra Admindcompra = new clsAdmindetallecompra();
        public DataGridView midata;

        public MPagocompra(clsUsuario Usuario)
        {
            InitializeComponent();
            Usser = Usuario;

            Combotpagoservicio.SelectedIndex = 0;
            Combodocumento.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["Formproveedor"] != null)
                {
                    Application.OpenForms["Formproveedor"].Activate();
                }
                else
                {
                    FormProveedor form = new FormProveedor();
                    form.ShowDialog();

                    if (form.cProveedor != null && form.cProveedor.Codproveedor != 0)
                    {
                        Miproveedor = form.cProveedor;
                        txtidproveedor.Text = Miproveedor.Codproveedor.ToString();
                        txtruc.Text = Miproveedor.Ruc.ToString();
                        txtrazonsocial.Text = Miproveedor.Razonsocial.ToString();
                        txtdireccion.Text = Miproveedor.Direccion.ToString();
                        txtcelular.Text = Miproveedor.Celular.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            try
            {
               

                if (txtpago.Text != string.Empty)
                {
                    int monto = Int32.Parse(labelmonto.Text);
                    int pago = Int32.Parse(txtpago.Text);


                    if (pago > monto)
                    {
                        MessageBox.Show("El pago debe ser menor o igual al monto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtpago.Clear();
                        textsaldo.Clear();
                        txtpago.Focus();
                    }
                    else if (pago == monto)
                    {
                        Combotpagoservicio.SelectedIndex = 0;
                        textsaldo.Text = Math.Abs(monto - pago).ToString();
                    }
                    else
                    {
                        Combotpagoservicio.SelectedIndex = 1;
                        textsaldo.Text = Math.Abs(monto - pago).ToString();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidproveedor.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar el proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtruc.Focus();
                }
                else if (txtpago.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el pago", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpago.Focus();
                }
                else
                {
                    //Miorden = new clsOrdenservicio();
                    Micompra.Id_usuario = Usser.Id_Trabajador;
                    Micompra.Id_proveedor = Int32.Parse(txtidproveedor.Text);
                    Micompra.Importe_total = Decimal.Parse(labelmonto.Text);
                    Micompra.Tipo_pago = Combotpagoservicio.SelectedItem.ToString();
                    Micompra.Pago = Decimal.Parse(txtpago.Text);
                    Micompra.Saldo = Decimal.Parse(textsaldo.Text);
                    Micompra.Documento = Combodocumento.SelectedItem.ToString();
                    Micompra.Numero_documento = txtnumerodoc.Text;
                    Micompra.Fecha_registro = DateTime.Now;

                    if (Mysqlcompra.insert(Micompra))
                    {

                        Midetallecompra(Micompra.Id_compra);
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE LA COMPRA ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el orden de servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Midetallecompra(Int32 idcompra)
        {
            try
            {

                clsDetallecompra detallecompra = new clsDetallecompra();
                detallecompra.Id_compra = idcompra;

                foreach (DataGridViewRow fila in midata.Rows)
                {
                    detallecompra.Id_producto = Int32.Parse(fila.Cells[4].Value.ToString());
                    detallecompra.Cantidad = Int32.Parse(fila.Cells[1].Value.ToString());
                    detallecompra.Precio_compra = Decimal.Parse(fila.Cells[2].Value.ToString());
                    detallecompra.Importe_total = Decimal.Parse(fila.Cells[3].Value.ToString());

                    if (Admindcompra.insert(detallecompra))
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
