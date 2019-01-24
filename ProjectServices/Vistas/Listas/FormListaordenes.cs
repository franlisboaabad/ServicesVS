using ProjectServices.Administrador;
using ProjectServices.Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormListaordenes : Form
    {
        clsServicio cServicio;
        clsAdminOS Adminos = new clsAdminOS();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public FormListaordenes()
        {
            InitializeComponent();
            Mis_ordenservicio();
            textbuscar.Focus();
            Gridaservicios.DefaultCellStyle.Font = new Font("Century Gothic", 10);
        }


        /*Listar odenes de servicio, nombre o cliente*/
        private void Listar_ordenservicio(string nombre,string apellidos)
        {
            try
            {
                dt = Adminos.Lista_ordenservicio(nombre,apellidos);
                ds.Tables.Add(dt);
                Gridaservicios.DataSource = dt;
                MostrarDocumentos();
                Inactivo(Gridaservicios);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Listar odenes de servicio, nombre o cliente*/
        private void Mis_ordenservicio()
        {
            try
            {
                dt = Adminos.Listar_ordenservicio();
                ds.Tables.Add(dt);
                Gridaservicios.DataSource = dt;
                MostrarDocumentos();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*ocultar columnas no deseadas*/
        private void MostrarDocumentos()
        {
            Gridaservicios.Columns[0].Visible = false;
            Gridaservicios.Columns[1].Width = 300;
            Gridaservicios.Columns[2].Width = 200;
            Gridaservicios.Columns[3].Width = 150;
            Gridaservicios.Columns[4].Width = 150;

            Gridaservicios.RowTemplate.Height = 40;
        }

        private void Inactivo(DataGridView midata)
        {
            try
            {
                foreach (DataGridViewRow fila in midata.Rows)
                {
                    if (fila.Cells[14].Value.ToString() == "INACTIVO")
                    {
                        fila.Cells[14].Style.BackColor = Color.Pink;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbuscar.Text != string.Empty)
                {
                    string buscador = textbuscar.Text.Trim();

                    Listar_ordenservicio(buscador,buscador);

                }else
                {
                    Mis_ordenservicio();
                    MessageBox.Show("Debe ingresar el Nombre o Apellido para realizar la busqueda..", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textbuscar.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea anular la orden de servicio ?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    int j = (int)Gridaservicios.SelectedRows.Count;
                    
                    if (j != 0)
                    {
                       

                        int fil = Int32.Parse( Gridaservicios.CurrentRow.Index.ToString());
                        int codigo = Int32.Parse(Gridaservicios.Rows[fil].Cells[0].Value.ToString());

                        if (Adminos.Anular_ordenservicio(codigo))
                        {
                            MessageBox.Show("ORDEN DE SERVICIO ANULADA CON EXITO", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Mis_ordenservicio();
                        }else
                        {
                            MessageBox.Show("Error", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Debe seleccionar orden de servicio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
