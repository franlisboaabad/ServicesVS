using ProjectServices.Administrador;
using ProjectServices.Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormServicios : MetroFramework.Forms.MetroForm
    {
        public clsServicio cServicio;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        clsAdminServicio AdmServicio = new clsAdminServicio();

        public FormServicios()
        {
            InitializeComponent();
            ListarServicio();
            dataservicios.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            
        }

      

        /*listar servicio*/
        private void ListarServicio()
        {
            try
            {
                dt = AdmServicio.lista_Servicio();
                ds.Tables.Add(dt);
                dataservicios.DataSource = dt;
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
            dataservicios.Columns[0].Visible = false;
            dataservicios.Columns[4].Visible = false;

            dataservicios.Columns[1].Width = 400;
            dataservicios.Columns[3].Width = 400;

            dataservicios.RowTemplate.Height = 30;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿ Desea agregar el servicio seleccionado ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cServicio = new clsServicio();

                    cServicio.CodigoServicio = Convert.ToInt32(dataservicios.CurrentRow.Cells[0].Value.ToString());
                    cServicio.Servicio = dataservicios.CurrentRow.Cells[1].Value.ToString();
                    cServicio.Costo = Double.Parse(dataservicios.CurrentRow.Cells[2].Value.ToString());
                    cServicio.Descripcion = dataservicios.CurrentRow.Cells[3].Value.ToString();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error del sistema ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormServicios_Load(object sender, EventArgs e)
        {

        }

        private void FormServicios_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
