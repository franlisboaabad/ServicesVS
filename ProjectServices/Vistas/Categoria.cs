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
using ProjectServices.Conexion;
using ProjectServices.Entidades;
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;



namespace ProjectServices
{
    public partial class Categoria : Form
    {
        clsCategoria cCategoria;
        clsAdminCategoria AdmCategoria = new clsAdminCategoria();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public Categoria()
        {
            InitializeComponent();
            ListaCategoria();
            Controles();
            ControlCajas(false);
            dataGridView1.DefaultCellStyle.Font = new  Font("Century Gothic", 10);
            
        }

        private void ListaCategoria()
        {
            try
            {
                dt = AdmCategoria.lista_Categoria();
                ds.Tables.Add(dt);
                dataGridView1.DataSource = dt;
                MostrarDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDocumentos()
        {
            try
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;


                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.Columns[3].Width = 100;

                dataGridView1.RowTemplate.Height = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Controles()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
        }

        private void ActivarControl(bool bandera)
        {
            btnsave.Enabled = bandera;
            btnupdate.Enabled = false;
            btncancel.Enabled = bandera;

            ControlCajas(true);
            textcategoria.Focus();
        }
        
        private void ControlEditar(bool bandera)
        {
            btnupdate.Enabled = bandera;
            btnnuevo.Enabled = false;
            btncancel.Enabled = true;
            btnsave.Enabled = false;
        }

        private void ControlCajas( bool band)
        {
            textcategoria.Enabled = band;
            textdescripcion.Enabled = band;
        }

        private void LimpiarCajas()
        {
            textcategoria.Text = "";
            textdescripcion.Text = "";
            textcategoria.Select();
        }


        private bool isValidate()
        {
            bool no_error = true;

            if (textcategoria.Text == string.Empty)
            {
                errorProvider1.SetError(textcategoria, "Ingresar categoria porfavor");
                no_error = false;
            }
            return no_error;
        }


        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarControl(true);
            btnnuevo.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ActivarControl(false);
            ControlCajas(false);
            btnnuevo.Enabled = true;
            errorProvider1.Clear();
            LimpiarCajas();
        }

        


        /*codigo botones*/ 
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cCategoria = new clsCategoria();
                if (isValidate())
                {
                    cCategoria.Nombre = textcategoria.Text.ToUpper();
                    cCategoria.Descripcion = textdescripcion.Text.ToUpper();

                    if (AdmCategoria.insert(cCategoria))
                    {
                        MessageBox.Show("CATEGORIA REGISTRADA CORRECTAMENTE", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListaCategoria();
                        LimpiarCajas();
                    }

                }
              

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (textbuscar.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + textbuscar.Text + "%'";
                dataGridView1.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                DialogResult resul = MessageBox.Show("¿ ESTA SEGURO DE ELIMINAR LA CATEGORIA ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    cCategoria = new clsCategoria();

                    try
                    {

                        if (textcodigo.Text != string.Empty)
                        {
                            cCategoria.Id_Categoria = Convert.ToInt32(textcodigo.Text);

                            if (AdmCategoria.delete(cCategoria))
                            {
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINAR REGISTRO", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ListaCategoria();
                                textcodigo.Text = "";
                                checkBox2.Checked = false;

                            }

                        }

                        else
                        {
                            MessageBox.Show("Seleccionar la categoria a eliminar ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            checkBox2.Checked = false;
                        }

           
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error del sistema  : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    checkBox2.Checked = false;
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               textcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();   

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textcategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textdescripcion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                tabControl1.SelectedTab = tabPage1;
                ControlCajas(true);
                ControlEditar(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cCategoria = new clsCategoria();

                if (isValidate())
                {
                    cCategoria.Id_Categoria = Convert.ToInt32(textcodigo.Text);
                    cCategoria.Nombre = textcategoria.Text.Trim().ToUpper();
                    cCategoria.Descripcion = textdescripcion.Text.ToUpper();
                    

                    if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR CATEGORIA ? ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdmCategoria.update(cCategoria))
                        {
                            MessageBox.Show("CATEGORIA MODIFICADA CORRECTAMENTE ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LimpiarCajas();
                            ListaCategoria();
                        }
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
