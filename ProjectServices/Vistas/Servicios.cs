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
        clsServicio cServicio;
        clsProducto cProducto;
        clsOrdenservicio cOS;

        clsAdminCategoria AdmCategoria = new clsAdminCategoria();
        clsAdminServicio AdmServicio = new clsAdminServicio();
        clsAdminProducto AdmProducto = new clsAdminProducto();
        clsAdminOS AdmOS = new clsAdminOS();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();



        public Servicios(clsUsuario Usser)
        {
            InitializeComponent();
            this.Width = 1280;

            Gridaservicios.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            Gridaproductos.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            Gridaservicios.RowTemplate.Height = 40;
            Gridaproductos.RowTemplate.Height = 40;

            cTecnico = Usser;
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            EstadoServicio();

        }

     

       


        private void LimpiarCajas()
        {
            metroComboBox1.SelectedIndex = 0;


            foreach (Control item in this.Controls)
            {
                    if (item is GroupBox)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                            metroComboBox1.Select();
                        }
                    }

            }
           
        }


        
        
        private void EstadoServicio()
        {
            metroComboBox1.Items.Add("ABIERTO");
            metroComboBox1.Items.Add("EN CURSO");
            metroComboBox1.Items.Add("FINALIZADO");
            metroComboBox1.SelectedIndex = 0;
        }

        
        private void btnnuevo_Click(object sender, EventArgs e)
        {
          
            validarTextBoxs();
            Gridaproductos.Rows.Clear();
            Gridaservicios.Rows.Clear();
            ImporteFinal(Gridaservicios, Gridaproductos);
        }

       

        private void btnServicios_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FormServicios"] != null)
                {
                    Application.OpenForms["FormServicios"].Activate();
                }
                else
                {
                    FormServicios form = new FormServicios();
                    form.ShowDialog();

                    cServicio = new clsServicio();

                    int fila = Gridaservicios.Rows.Count;
                   

                    if (form.cServicio != null && form.cServicio.CodigoServicio != 0)
                    {
                        Gridaservicios.Rows.Add();
                        cServicio = form.cServicio;
                        Gridaservicios.Rows[fila].Cells[0].Value = cServicio.CodigoServicio;
                        Gridaservicios.Rows[fila].Cells[1].Value = cServicio.Servicio;
                        Gridaservicios.Rows[fila].Cells[2].Value = cServicio.Costo;
                        Gridaservicios.Rows[fila].Cells[3].Value = cServicio.Descripcion;
                        ImporteFinal(Gridaservicios, Gridaproductos);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FormProducto"] != null)
                {
                    Application.OpenForms["FormProducto"].Activate();
                }
                else
                {
                    FormProducto form = new FormProducto();
                    form.ShowDialog();

                    cProducto = new clsProducto();

                    int fila = Gridaproductos.Rows.Count;
                  

                    if (form.Product != null && form.Product.Codproducto != 0)
                    {
                        Gridaproductos.Rows.Add();
                        cProducto = form.Product;
                        Gridaproductos.Rows[fila].Cells[0].Value = cProducto.Codproducto;
                        Gridaproductos.Rows[fila].Cells[1].Value = cProducto.Nombre;
                        Gridaproductos.Rows[fila].Cells[2].Value = cProducto.Cantidad;
                        Gridaproductos.Rows[fila].Cells[3].Value = cProducto.Precioventa;
                        Gridaproductos.Rows[fila].Cells[4].Value = cProducto.Subtotal;
                        ImporteFinal(Gridaservicios, Gridaproductos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void ImporteFinal(DataGridView servicios, DataGridView productos)
        {
            try
            {
                Double tservicios = 0;
                Double tproductos = 0;


                if (servicios.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in servicios.Rows)
                    {
                        tservicios += Convert.ToDouble(row.Cells["COSTO"].Value);
                    }
                }

                if (productos.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in productos.Rows)
                    {
                        tproductos += Convert.ToDouble(row.Cells[4].Value);
                    }
                }

                labelimporte.Text = Convert.ToString(tservicios + tproductos);
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gridaservicios_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el servicio?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int j = Gridaservicios.Rows.Count;

                    if (j > 0)
                    {

                        int x = Gridaservicios.CurrentRow.Index;

                        Gridaservicios.Rows.RemoveAt(x);
                        ImporteFinal(Gridaservicios,Gridaproductos);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gridaproductos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el producto?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int j = Gridaproductos.Rows.Count;

                    if (j > 0)
                    {

                        int x = Gridaproductos.CurrentRow.Index;

                        Gridaproductos.Rows.RemoveAt(x);
                        ImporteFinal(Gridaservicios, Gridaproductos);
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (Application.OpenForms["MPagoservicio"] != null)
                    {
                        Application.OpenForms["MPagoservicio"].Activate();
                    }
                    else
                    {
                        int j = Gridaservicios.Rows.Count;
                        int i = Gridaproductos.Rows.Count;

                        cOS = new clsOrdenservicio();
                        cOS.Id_tecnico = cTecnico.Id_Trabajador;
                        cOS.Estadoservicio = metroComboBox1.SelectedItem.ToString();
                        cOS.Fechainicial = DateTime.Today;
                        cOS.Fechafinal = DateTime.Parse(dtpfechainicial.Text);
                        cOS.Garantia = textgarantia.Text;
                        cOS.DescripcionProducto = textdescripcion.Text;
                        cOS.Observaciones = textobservaciones.Text;
                        cOS.Diagnostico = txtdiagnosticotecnico.Text;

                        if (cOS.Estadoservicio.Equals(""))
                        {
                            MessageBox.Show("Ingresar Estado del servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            metroComboBox1.Focus();
                        }else if(cOS.Garantia.Equals(""))
                        {
                            MessageBox.Show("Ingresar garantia del servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textgarantia.Focus();
                        }else if (cOS.DescripcionProducto.Equals(""))
                        {
                            MessageBox.Show("Ingresar descripcion del producto / servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textdescripcion.Focus();
                        }else if (cOS.Observaciones.Equals(""))
                        {
                            MessageBox.Show("Ingresar observaciones del servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textobservaciones.Focus();
                        }
                        else if (cOS.Diagnostico.Equals(""))
                        {
                            MessageBox.Show("Ingresar diagnostico del servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtdiagnosticotecnico.Focus();
                        }else if (j <= 0 && i <= 0)
                        {
                            MessageBox.Show("Debe añadir servicios o productos en lista.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }else
                        {
                            MPagoservicio form = new MPagoservicio(cOS);
                            form.midataservicio = Gridaservicios;
                            form.midataproducto = Gridaproductos;
                            form.labelmonto.Text = labelimporte.Text;
                            form.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarTextBoxs()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    foreach (Control c in ((GroupBox)item).Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        private bool comprobarTextboxs()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    foreach (Control c in ((GroupBox)item).Controls)
                    {
                        if (c is TextBox)
                        {
                            if (c.Text.Equals(""))
                            {
                                MessageBox.Show("Ingresar el siguiente campo porfavor ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                c.Focus();
                            }
                        }

                        if (c is MetroFramework.Controls.MetroComboBox)
                        {
                            if (c.Text.Equals(""))
                            {
                                MessageBox.Show("Seleccionar....", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                c.Focus();
                            }
                        }
                    }
                }
                catch { }
            }
            return true;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(metroComboBox1.SelectedItem.ToString());
        }
    }
}
