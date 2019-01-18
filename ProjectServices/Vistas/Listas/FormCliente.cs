using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectServices.Administrador;
using ProjectServices.Entidades;

namespace ProjectServices.Vistas.Listas
{
    public partial class FormCliente : MetroFramework.Forms.MetroForm
    {
        
        public clsCliente cCliente;
        clsAdminCliente AdminCliente = new clsAdminCliente();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        

        public FormCliente()
        {
            InitializeComponent();
            ListarClientes();
            dataclientes.DefaultCellStyle.Font = new Font("Century Gothic", 10);
        }

        private void ListarClientes()
        {
            try
            {
                dt = AdminCliente.lista_clientes();
                ds.Tables.Add(dt);
                dataclientes.DataSource = dt;
                MostrarDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDocumentos()
        {
            dataclientes.Columns[0].Visible = false;
            dataclientes.Columns[9].Visible = false;
            dataclientes.Columns[3].Visible = false;
            dataclientes.Columns[4].Visible = false;
            dataclientes.Columns[8].Visible = false;

            dataclientes.Columns[1].Width = 250;
            dataclientes.Columns[2].Width = 350;
            dataclientes.Columns[5].Width = 150;
            dataclientes.Columns[6].Width = 400;
            
            dataclientes.RowTemplate.Height = 30;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (textbuscar.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + textbuscar.Text + "%'";
                dataclientes.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿ Desea agregar al cliente seleccionado ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cCliente = new clsCliente();
                    cCliente.Id_Cliente = Convert.ToInt32(dataclientes.CurrentRow.Cells[0].Value.ToString());
                    cCliente.Nombre = dataclientes.CurrentRow.Cells[1].Value.ToString();
                    cCliente.Apellidos = dataclientes.CurrentRow.Cells[2].Value.ToString();
                    cCliente.Documento = dataclientes.CurrentRow.Cells[5].Value.ToString();
                    cCliente.Direccion = dataclientes.CurrentRow.Cells[6].Value.ToString();
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
