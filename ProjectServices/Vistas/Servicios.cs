using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ProjectServices.Vistas.Listas;
using ProjectServices.Administrador;
using ProjectServices.Entidades;

namespace ProjectServices.Vistas
{
    public partial class Servicios : Form
    {

        clsCliente cCliente;
        clsUsuario cTecnico;
        clsCategoria cCategoria;
        clsServicio cServicio;
        clsOrdenservicio cOS;

        clsAdminCategoria AdmCategoria = new clsAdminCategoria();
        clsAdminServicio AdmServicio = new clsAdminServicio();
        clsAdminProducto AdmProducto = new clsAdminProducto();
        clsAdminOS AdmOS = new clsAdminOS();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();



        public Servicios()
        {
            InitializeComponent();
            
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            ListaProductos();
            ListarServicios();

            DGVproductos.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            DGVProducts.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            DGVservicios.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            DGVservice.DefaultCellStyle.Font = new Font("Century Gothic", 10);

            EstadoServicio();
            Controles();
            ActivarControl(false);
        }

        private void Controles()
        {
            btnsave.Enabled = false;
            btncancel.Enabled = false;
            btnImprime.Enabled = false;
        }

        private void ActivarControl(bool bandera)
        {
            btnsave.Enabled = bandera;
            btnImprime.Enabled = bandera;
            btncancel.Enabled = bandera;

            ControlCajas(bandera);
            
        }

        private void ControlEditar(bool bandera)
        {
            btnnuevo.Enabled = false;
            btncancel.Enabled = true;
            btnsave.Enabled = false;
        }

        private void ControlCajas(bool band)
        {
            textcliente.Enabled = band;
            txtdocumento.Enabled = band;
            textdireccion.Enabled = band;
            txttecnico.Enabled = band;
            comboestado.Enabled = band;
            dtpfechafinal.Enabled = band;
            dtpfechainicial.Enabled = band;
            textgarantia.Enabled = band;
            textdescripcion.Enabled = band;
            textobservaciones.Enabled = band;
            txtdiagnosticotecnico.Enabled = band;

            buttonclientes.Enabled = band;
            buttonTécnicos.Enabled = band;

            textcliente.Select();
        }

        private void LimpiarCajas()
        {
            textcliente.Text = "";
            txtdocumento.Text = "";
            textdireccion.Text = "";
            txttecnico.Text = "";
            comboestado.SelectedIndex = 0;
            textgarantia.Text = ""; 
            textdescripcion.Text = "";
            textobservaciones.Text = "";
            txtdiagnosticotecnico.Text = "";
        }


        private bool isValidate()
        {
            bool no_error = true;

            if (txtidcliente.Text == string.Empty)
            {
                errorProvider1.SetError(textcliente, "Ingresar cliente porfavor");
                no_error = false;
            }
            else
            {
                if (txtidtecnico.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txttecnico, "Ingresar Técnico porfavor");
                    no_error = false;
                }

                if (comboestado.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(comboestado, "Ingresar Estado de servicio porfavor");
                    no_error = false;
                }

                if (textgarantia.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textgarantia, "Ingresar garantía porfavor");
                    no_error = false;
                }

                if (textdescripcion.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textdescripcion, "Ingresar Descrpción del producto/servicio porfavor");
                    no_error = false;
                }

            }
           
            return no_error;
        }

        

        private void ListaProductos()
        {
            try
            {
                dt = AdmProducto.lista_Productos();
                ds.Tables.Add(dt);
                DGVproductos.DataSource = dt;
                MostrarDocumentosProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarServicios()
        {
            try
            {
                dt = AdmServicio.lista_Servicio();
                ds.Tables.Add(dt);
                DGVservicios.DataSource = dt;
                MostrarDocumentosService();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MostrarDocumentosProducto()
        {
            DGVproductos.Columns[0].Visible = false;
            DGVproductos.Columns[3].Visible = false;
            DGVproductos.Columns[4].Visible = false;
            DGVproductos.Columns[5].Visible = false;
            DGVproductos.Columns[8].Visible = false;
            DGVproductos.Columns[9].Visible = false;
            DGVproductos.Columns[10].Visible = false;

            DGVproductos.Columns[0].Width = 80;
            DGVproductos.Columns[1].Width = 250;
            DGVproductos.Columns[2].Width = 350;
            DGVproductos.Columns[3].Width = 100;
            DGVproductos.Columns[7].Width = 200;

            DGVproductos.RowTemplate.Height = 30;


            /*DGV PRODUCTS*/
            DGVProducts.Columns[0].Width = 350;
            DGVProducts.Columns[1].Width = 100;
            DGVProducts.Columns[2].Width = 120;
            DGVProducts.Columns[3].Width = 100;


            DGVProducts.RowTemplate.Height = 30;
        }


        private void MostrarDocumentosService()
        {
            DGVservicios.Columns[0].Visible = false;
            DGVservicios.Columns[4].Visible = false;

            DGVservicios.Columns[1].Width = 400;
            DGVservicios.Columns[3].Width = 300;
            DGVservicios.RowTemplate.Height = 30;

            /*DGV PRODUCTS*/
            DGVservice.Columns[0].Width = 350;
            DGVservice.Columns[1].Width = 100;
            DGVservice.Columns[2].Width = 100;
            DGVservice.Columns[2].Width = 150;
            DGVservice.RowTemplate.Height = 30;
        }


        private void EstadoServicio()
        {
            comboestado.Items.Add("Presupuestado");
            comboestado.Items.Add("Abierto");
            comboestado.Items.Add("En curso");
            comboestado.Items.Add("Finalizado");
        }

        private void buttonclientes_Click(object sender, EventArgs e)
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
                    textdireccion.Text = cCliente.Direccion.ToString();
                    textcliente.Select();

                }
            }
        }

        /*Guardar OS*/
        private void btnsave_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (isValidate())
                {
                    cOS = new clsOrdenservicio();


                    cOS.Id_cliente = cCliente.Id_Cliente;
                    cOS.Id_tecnico = cTecnico.Id_Trabajador;
                    cOS.Estadoservicio = comboestado.SelectedText;
                    cOS.Fechainicial = Convert.ToDateTime(dtpfechainicial.Text);
                    cOS.Fechafinal = Convert.ToDateTime(dtpfechafinal.Text);
                    cOS.Garantia = textgarantia.Text.ToString().ToUpper();
                    cOS.DescripcionProducto = textdescripcion.Text.ToString().ToUpper();
                    cOS.Observaciones = textobservaciones.Text.ToString().ToUpper();
                    cOS.Diagnostico = txtdiagnosticotecnico.Text.ToString().ToUpper();

                    if (AdmOS.insert(cOS))
                    {
                        MessageBox.Show("ORDEN DE SERVICIO REGISTRADO", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /*Busuqeda del tecnico*/
        private void buttonTécnicos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormTecnico"] != null)
            {
                Application.OpenForms["FormTecnico"].Activate();
            }
            else
            {
                FormTecnico form = new FormTecnico();
                form.ShowDialog();

                if (form.cTecnico != null && form.cTecnico.Id_Trabajador != 0)
                {
                    cTecnico = form.cTecnico;
                    txtidtecnico.Text = cTecnico.Id_Trabajador.ToString();
                    txttecnico.Text = cTecnico.Nombre.ToString() + " " + cTecnico.Apellidos.ToString();
                }

            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarControl(true);
        }

        /*tabcontrols codigo para registrar productos y servicios | detalles de OS*/
        private void txtcategoriaproducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fieldName = string.Concat("[", dt.Columns[2].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtcategoriaproducto.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtcategoriaproducto.Text + "%'";
                DGVproductos.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            try
            {
                int j = DGVProducts.Rows.Count;

                if (txtcantidad.Text != string.Empty)
                {
                    DGVProducts.Rows.Add();
                    DGVProducts.Rows[j].Cells[0].Value = DGVproductos.CurrentRow.Cells[1].Value.ToString();
                    DGVProducts.Rows[j].Cells[1].Value = Int32.Parse(txtcantidad.Text);
                    DGVProducts.Rows[j].Cells[2].Value = DGVproductos.CurrentRow.Cells[7].Value.ToString();

                    double pventa = Double.Parse(DGVproductos.CurrentRow.Cells[7].Value.ToString());
                    int cantidad = Int32.Parse(txtcantidad.Text);
                    double subtotal = cantidad * pventa;
                    DGVProducts.Rows[j].Cells[3].Value = subtotal;

                    ImportetotalProductos();
                }
                else
                {
                    MessageBox.Show("Ingresar cantidad de productos  " , "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcantidad.Select();
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

            if (DGVProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVProducts.Rows)
                {
                    total += Convert.ToDouble(row.Cells["Subtotal"].Value);
                }
            }

            lblcostoproducto.Text = Convert.ToString(total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int j = DGVProducts.Rows.Count;

                if (j > 0)
                {

                    int x = DGVProducts.CurrentRow.Index;

                    DGVProducts.Rows.RemoveAt(x);
                    ImportetotalProductos();
                }

                else
                {
                    MessageBox.Show("SELECCIONAR EL PRODUCTO A ELIMINAR", "INFORMACIÓN", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, " ERROR! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbuscarservicio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtbuscarservicio.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtbuscarservicio.Text + "%'";
                DGVservicios.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int j = DGVservice.Rows.Count;

                if (txtcantidadservicio.Text != string.Empty)
                {
                    DGVservice.Rows.Add();
                    DGVservice.Rows[j].Cells[0].Value = DGVservicios.CurrentRow.Cells[1].Value.ToString();
                    DGVservice.Rows[j].Cells[1].Value = DGVservicios.CurrentRow.Cells[2].Value.ToString();
                    DGVservice.Rows[j].Cells[2].Value = Int32.Parse(txtcantidadservicio.Text);

                    double costo = Double.Parse(DGVservicios.CurrentRow.Cells[2].Value.ToString());
                    int cantidad = Int32.Parse(txtcantidadservicio.Text);
                    double subtotal = cantidad * costo;
                    DGVservice.Rows[j].Cells[3].Value = subtotal;

                    ImportetotalServicios();
                }
                else
                {
                    MessageBox.Show("Ingresar la cantidad del servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcantidad.Select();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ImportetotalServicios()
        {
            Double total = 0;

            if (DGVservice.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVservice.Rows)
                {
                    total += Convert.ToDouble(row.Cells["sSubtotal"].Value);
                }
            }

            lbltotalservicio.Text = Convert.ToString(total);
        }

        private void btneliminarservicio_Click(object sender, EventArgs e)
        {
            try
            {
                int j = DGVservice.Rows.Count;

                if (j > 0)
                {

                    int x = DGVservice.CurrentRow.Index;

                    DGVservice.Rows.RemoveAt(x);
                    ImportetotalServicios();
                }

                else
                {
                    MessageBox.Show("SELECCIONAR EL SERVICIO A ELIMINAR", "INFORMACIÓN", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, " ERROR! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
