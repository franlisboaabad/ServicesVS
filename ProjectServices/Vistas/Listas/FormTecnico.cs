using ProjectServices.Administrador;
using ProjectServices.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormTecnico : MetroFramework.Forms.MetroForm
    {

        public clsUsuario cTecnico;
        clsAdminUsuario AdminTecnico = new clsAdminUsuario();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public FormTecnico()
        {
            InitializeComponent();
            ListarTecnicos();
            datatecnicos.DefaultCellStyle.Font = new Font("Century Gothic", 10);
        }

        private void FormTecnico_Load(object sender, EventArgs e)
        {
           
        }

        private void ListarTecnicos()
        {
            try
            {
                dt = AdminTecnico.lista_Usuarios();
                ds.Tables.Add(dt);
                datatecnicos.DataSource = dt;
                MostrarDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDocumentos()
        {
            datatecnicos.Columns[0].Visible = false;
            datatecnicos.Columns[3].Visible = false;
            datatecnicos.Columns[4].Visible = false;
            datatecnicos.Columns[5].Visible = false;
            
            datatecnicos.Columns[8].Visible = false;
            datatecnicos.Columns[9].Visible = false;
            datatecnicos.Columns[10].Visible = false;
            datatecnicos.Columns[11].Visible = false;

            datatecnicos.Columns[1].Width = 250;
            datatecnicos.Columns[2].Width = 350;
            datatecnicos.Columns[5].Width = 150;
            datatecnicos.Columns[6].Width = 400;

            datatecnicos.RowTemplate.Height = 30;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿ Desea agregar al Técnico seleccionado ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cTecnico = new clsUsuario();
                    cTecnico.Id_Trabajador = Convert.ToInt32(datatecnicos.CurrentRow.Cells[0].Value.ToString());
                    cTecnico.Nombre = datatecnicos.CurrentRow.Cells[1].Value.ToString();
                    cTecnico.Apellidos = datatecnicos.CurrentRow.Cells[2].Value.ToString();
                    
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
