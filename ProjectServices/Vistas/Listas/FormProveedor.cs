using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


using ProjectServices.Administrador;
using ProjectServices.Entidades;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormProveedor : MetroFramework.Forms.MetroForm
    {
        public clsProveedor cProveedor;
        clsAdminProveedor AdminProveedor = new clsAdminProveedor();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public FormProveedor()
        {
            InitializeComponent();
            ListarProveedores();
            dataproveedor.DefaultCellStyle.Font = new Font("Century Gothic", 11);
        }

        /*listar proveedor*/
        private void ListarProveedores()
        {
            try
            {
                dt = AdminProveedor.lista_Proveedor();
                ds.Tables.Add(dt);
                dataproveedor.DataSource = dt;
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
            dataproveedor.Columns[0].Visible = false;
            dataproveedor.Columns[7].Visible = false;

            dataproveedor.Columns[1].Width = 250;
            dataproveedor.Columns[2].Width = 350;
            dataproveedor.Columns[3].Width = 200;
            dataproveedor.Columns[4].Width = 150;
            dataproveedor.Columns[6].Width = 350;

            dataproveedor.RowTemplate.Height = 40;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿ Desea agregar al cliente seleccionado ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cProveedor = new clsProveedor();
                    cProveedor.Codproveedor = Convert.ToInt32(dataproveedor.CurrentRow.Cells[0].Value.ToString());
                    cProveedor.Ruc = dataproveedor.CurrentRow.Cells[1].Value.ToString();
                    cProveedor.Razonsocial = dataproveedor.CurrentRow.Cells[2].Value.ToString();
                    cProveedor.Direccion = dataproveedor.CurrentRow.Cells[3].Value.ToString();
                    cProveedor.Celular = dataproveedor.CurrentRow.Cells[5].Value.ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error del sistema ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
