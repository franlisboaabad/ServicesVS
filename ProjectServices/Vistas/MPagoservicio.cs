using ProjectServices.Vistas.Listas;
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
using ProjectServices.Administrador;

namespace ProjectServices.Vistas
{
    public partial class MPagoservicio : MetroFramework.Forms.MetroForm
    {
        private clsCliente cCliente;
        clsOrdenservicio Miorden;
        
        public DataGridView midataservicio,midataproducto;

        clsAdminOS MysqlOrden = new clsAdminOS();
        clsAdminDetalle_os_producto Admin_os_producto = new clsAdminDetalle_os_producto();
        clsAdminDetalle_os_servicio Admin_os_servicio = new clsAdminDetalle_os_servicio();

        public MPagoservicio(clsOrdenservicio orden)
        {
            InitializeComponent();
            Combotpagoservicio.SelectedIndex = 0;
            Miorden = orden;
        }

        private void MPagoservicio_Load(object sender, EventArgs e)
        {

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

        private void Combotpagoservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Combotpagoservicio.SelectedIndex == 1)
                {
                    
                }

                if (Combotpagoservicio.SelectedIndex == 2)
                {
                    txtpago.Clear();
                }

                if (Combotpagoservicio.SelectedIndex==0)
                {
                    txtpago.Clear();
                    txtvuelto.Clear();
                    textsaldo.Clear();
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
                        textsaldo.Text = Math.Abs(monto - pago).ToString();
                    }
                    else
                    {
                        txtvuelto.Text = Math.Abs(monto - pago).ToString();
                        textsaldo.Text = "00.00";
                    }
                    
                }

            }
            catch (Exception)
            {
                txtvuelto.Text = "00.00";
                textsaldo.Text = "00.00";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidcliente.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar el cliente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textcliente.Focus();
                }
                else if (txtpago.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el pago", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtpago.Focus();
                }
                else
                {
                    // Miorden = new clsOrdenservicio();
                    Miorden.Id_cliente = Int32.Parse(txtidcliente.Text);
                    Miorden.Importe_total = Decimal.Parse(labelmonto.Text);
                    Miorden.Tipo_pago = Combotpagoservicio.SelectedItem.ToString();
                    Miorden.Pago = Decimal.Parse(txtpago.Text);
                    Miorden.Vuelto = Decimal.Parse(txtvuelto.Text);
                    Miorden.Saldo = Decimal.Parse(textsaldo.Text);

                    if (MysqlOrden.insert(Miorden))
                    {
                        Midetalle_os_producto(Miorden.Id_OS);
                        Midetalle_os_servicio(Miorden.Id_OS);
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE LA ORDEN DE SERVICIO Y SU ESTADO ES : " + Miorden.Estadoservicio, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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

        /* Detalle_os_servicios */
        private void Midetalle_os_servicio(Int32 idservicio)
        {
            try
            {

                clsDetalle_dos_servicio dos_servicio = new clsDetalle_dos_servicio();
                dos_servicio.Id_OS = idservicio;

                foreach (DataGridViewRow fila in midataservicio.Rows)
                {
                    dos_servicio.Id_Service = Int32.Parse(fila.Cells[0].Value.ToString());
                    dos_servicio.Costo = Decimal.Parse(fila.Cells[2].Value.ToString());

                    if (Admin_os_servicio.insert(dos_servicio))
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


        /* Detalle_os_productos */
        private void Midetalle_os_producto(Int32 idservicio)
        {
            try
            {

                clsDetalle_dos_producto dos_producto = new clsDetalle_dos_producto();
                dos_producto.Id_OS = idservicio;

                foreach (DataGridViewRow fila in midataproducto.Rows)
                {
                    dos_producto.Id_producto = Int32.Parse(fila.Cells[0].Value.ToString());
                    dos_producto.Cantidad = Int32.Parse(fila.Cells[2].Value.ToString());
                    dos_producto.Costo = Decimal.Parse(fila.Cells[3].Value.ToString());
                    dos_producto.Importe_total = Decimal.Parse(fila.Cells[4].Value.ToString());

                    if (Admin_os_producto.insert(dos_producto))
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

    }
}
