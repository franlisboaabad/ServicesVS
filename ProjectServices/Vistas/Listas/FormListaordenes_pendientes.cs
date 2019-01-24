using ProjectServices.Administrador;
using ProjectServices.Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormListaordenes_pendientes : Form
    {
        clsServicio cServicio;
        clsAdminOS Adminos = new clsAdminOS();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public FormListaordenes_pendientes()
        {
            InitializeComponent();
            Gridaservicios.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            Mis_ordenservicio_pendientes();
            MostrarDocumentos();

        }

        /*Listar odenes pendientes*/
        private void Mis_ordenservicio_pendientes()
        {
            try
            {
                dt = Adminos.Listar_ordenes_pendientes();
                ds.Tables.Add(dt);
                Gridaservicios.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ordenesporcancelar(DataGridView datagrid)
        {
            try
            {
                foreach (DataGridViewRow fila in datagrid.Rows)
                {


                    decimal saldo = Convert.ToDecimal(fila.Cells[13].Value);

                    if (saldo > 0)
                    {

                        fila.DefaultCellStyle.BackColor = Color.Pink;

                    }
                    else
                    {
                        fila.DefaultCellStyle.BackColor = Color.White;
                    }

                }
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Gridaservicios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Ordenesporcancelar(Gridaservicios);
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Verificarsaldo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
