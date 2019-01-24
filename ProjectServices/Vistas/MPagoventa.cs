using ProjectServices.Vistas.Listas;
using System;
using System.Windows.Forms;
using ProjectServices.Entidades;
using ProjectServices.Class;
using ProjectServices.Administrador;

namespace ProjectServices.Vistas
{
    public partial class MPagoventa : MetroFramework.Forms.MetroForm
    {

        private clsCliente cCliente;
        clsUsuario Usuario = new clsUsuario();
        clsVenta Miventa = new clsVenta();
        clsValidacion validar = new clsValidacion();

        clsAdminVenta AdmVenta = new clsAdminVenta();
        clsAdmindetalleventa AdmDetalle = new clsAdmindetalleventa();

        public DataGridView midata;

        public MPagoventa(clsUsuario Usser)
        {
            InitializeComponent();
            Usuario = Usser;
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["Formcliente"] != null)
                {
                    Application.OpenForms["Formcliente"].Activate();
                }
                else
                {
                    FormCliente form = new FormCliente();
                    form.ShowDialog();

                    if (form.cCliente != null && form.cCliente.Id_Cliente != 0)
                    {
                        cCliente = form.cCliente;
                        txtidcliente.Text = cCliente.Id_Cliente.ToString();
                        textcliente.Text = cCliente.Nombre.ToString() + " " + cCliente.Apellidos.ToString();
                        txtdocumento.Text = cCliente.Documento.ToString();
                        txtdireccion.Text = cCliente.Direccion.ToString();
                        txtcelular.Text = cCliente.Celular;
                        textcliente.Select();

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
                int monto = Int32.Parse(labelmonto.Text);
                int pago = Int32.Parse(txtpago.Text);

                if (pago.ToString() != string.Empty)
                {
                    if (pago < monto)
                    {
                        txtvuelto.Text = "00.00";
                     
                    }
                    else
                    {
                        txtvuelto.Text = Math.Abs(monto - pago).ToString();
                        
                    }

                }

            }
            catch (Exception)
            {
                txtvuelto.Text = "00.00";
            }
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidcliente.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar al cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textcliente.Focus();
                }
                else if (txtpago.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el pago", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpago.Focus();
                }
                else
                {
                    Miventa.Id_vendedor = Usuario.Id_Trabajador;
                    Miventa.Id_cliente = Int32.Parse(txtidcliente.Text);
                    Miventa.Fecha_registro = DateTime.Parse(dtpfechafinal.Text);
                    Miventa.Importe_total = Decimal.Parse(labelmonto.Text);
                    Miventa.Pago = Decimal.Parse(txtpago.Text);
                    Miventa.Vuelto = Decimal.Parse(txtvuelto.Text);

                    if (AdmVenta.insert(Miventa))
                    {
                        Midetalleventa(Miventa.Id_venta);
                        MessageBox.Show("SE REGISTRO LA VENTA CON EXITO !!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Midetalleventa(Int32 idventa)
        {
            try
            {
                
                clsDetalleventa detalleventa = new clsDetalleventa();
                detalleventa.Id_venta = idventa;

                foreach (DataGridViewRow fila in midata.Rows)
                {
                    detalleventa.Id_producto = Int32.Parse(fila.Cells[4].Value.ToString());
                    detalleventa.Cantidad = Int32.Parse(fila.Cells[1].Value.ToString());
                    detalleventa.Precio_venta = Decimal.Parse(fila.Cells[2].Value.ToString());
                    detalleventa.Importe_total = Decimal.Parse(fila.Cells[3].Value.ToString());

                    if (AdmDetalle.insert(detalleventa))
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
