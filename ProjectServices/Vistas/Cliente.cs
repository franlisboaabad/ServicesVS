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

namespace ProjectServices.Vistas
{
    public partial class Cliente : Form
    {
        clsCliente cCliente;
        clsAdminCliente AdminCliente = new clsAdminCliente();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Cliente()
        {
            InitializeComponent();
            Controles();
            ControlCajas(false);
            ListarClientes();
            dataclientes.DefaultCellStyle.Font = new Font("Century Gothic", 10);

            cargarCombos();
        }

        /*cargarcombos*/
        private void cargarCombos()
        {
            combosexo.Items.Add("Masculino");
            combosexo.Items.Add("Femenino");
            combosexo.Items.Add("Otros..");

            combodocumento.Items.Add("DNI");
            combodocumento.Items.Add("RUC");
            combodocumento.Items.Add("PASAPORTE");
        }
        /*listar clientes*/
        private void ListarClientes()
        {
            try
            {
                dt = AdminCliente.lista_clientes();
                ds.Tables.Add(dt);
                dataclientes.DataSource = dt;
                //EditColunm();
                MostrarDocumentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Validar cajas de texto*/
        private bool isValidate()
        {
            bool no_error = true;

            if (textnombre.Text == string.Empty)
            {
                errorProvider1.SetError(textnombre, "Ingresar nombre porfavor");
                no_error = false;
            }
            else
            {
                if (txtapellidos.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtapellidos, "Ingresar Apellidos porfavor");
                    return false;
                }

                

                if (txtdocumento.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtdocumento, "Ingresar numero de documento porfavor");
                    return false;
                }


            }

            return no_error;

        }

        private void ControlEditar(bool bandera)
        {
            btnupdate.Enabled = bandera;
            btnnuevo.Enabled = false;
            btncancel.Enabled = true;
            btnsave.Enabled = false;
        }


        /*ocultar columnas no deseadas*/
        private void MostrarDocumentos()
        {
            dataclientes.Columns[0].Visible = false;
            dataclientes.Columns[9].Visible = false;

            
            dataclientes.Columns[1].Width = 250;
            dataclientes.Columns[2].Width = 350;
            dataclientes.Columns[3].Width = 100;
            dataclientes.Columns[6].Width = 400;
            dataclientes.Columns[8].Width = 300;

            dataclientes.RowTemplate.Height = 30;
        }


        /*botones al inicio*/
        private void Controles()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btncancel.Enabled = false;
        }


        /*boton Nuevo*/
        private void ActivarControl(bool bandera)
        {
            btnsave.Enabled = bandera;
            btnupdate.Enabled = false;
            btncancel.Enabled = bandera;

            ControlCajas(true);
            textnombre.Select();
        }

        /*cajas de texto*/
        private void ControlCajas(bool band)
        {
            textnombre.Enabled = band;
            txtapellidos.Enabled = band;
            textcelular.Enabled = band;
            textemail.Enabled = band;

            combosexo.Enabled = band;
            combodocumento.Enabled = band;
            textdireccion.Enabled = band;
            txtdocumento.Enabled = band;

        }

        /*Limpiar cajas de texto*/
        private void LimpiarCajas(String band)
        {
            textnombre.Text = band;
            txtapellidos.Text = band;
            textcelular.Text = band;
            textemail.Text = band;

            textdireccion.Text = band;
            txtdocumento.Text = band;
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
            LimpiarCajas("");
        }

        private void combodocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combodocumento.SelectedItem.Equals("DNI"))
            {
                txtdocumento.MaxLength = 8;
                txtdocumento.Text = "";
                txtdocumento.Select();
            }

            if (combodocumento.SelectedItem.Equals("RUC"))
            {
                txtdocumento.MaxLength = 10;
                txtdocumento.Text = "";
                txtdocumento.Select();
            }


            if (combodocumento.SelectedItem.Equals("PASAPORTE"))
            {
                txtdocumento.MaxLength = 11;
                txtdocumento.Text = "";
                txtdocumento.Select();
            }
        }

        private void dataclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataclientes.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDelete.Checked)
            {
                DialogResult resul = MessageBox.Show("¿ ESTA SEGURO DE ELIMINAR AL CLIENTE ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    cCliente = new clsCliente();

                    try
                    {
                        if (textcodigo.Text != string.Empty)
                        {
                            cCliente.Id_Cliente = Convert.ToInt32(textcodigo.Text);

                            if (AdminCliente.delete(cCliente))
                            {
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINAR REGISTRO", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ListarClientes();
                                textcodigo.Text = "";
                                checkDelete.Checked = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccionar cliente a eliminar ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            checkDelete.Checked = false;
                        }

                       

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    checkDelete.Checked = false;
                }

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cCliente = new clsCliente();

                if (isValidate())
                {
                    cCliente.Nombre = textnombre.Text.ToUpper();
                    cCliente.Apellidos = txtapellidos.Text.ToUpper();
                    cCliente.Sexo = combosexo.SelectedItem.ToString();
                    cCliente.Tipo_documento = combodocumento.SelectedItem.ToString().ToUpper() ;
                    cCliente.Documento = txtdocumento.Text;
                    cCliente.Direccion = textdireccion.Text.ToUpper();
                    cCliente.Celular = textcelular.Text;
                    cCliente.Email = textemail.Text.ToUpper();

                    if (AdminCliente.insert(cCliente))
                    {
                        MessageBox.Show("CLIENTE REGISTRADO CORRECTAMENTE", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListarClientes();
                        LimpiarCajas("");
                        errorProvider1.Clear();
                    }

                }

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
                cCliente = new clsCliente();

                if (isValidate())
                {
                    cCliente.Id_Cliente = Convert.ToInt32(textcodigo.Text);
                    cCliente.Nombre = textnombre.Text.ToUpper();
                    cCliente.Apellidos = txtapellidos.Text.ToUpper();
                    cCliente.Sexo = combosexo.SelectedItem.ToString();
                    cCliente.Tipo_documento = combodocumento.SelectedItem.ToString().ToUpper();
                    cCliente.Documento = txtdocumento.Text;
                    cCliente.Direccion = textdireccion.Text.ToUpper();
                    cCliente.Celular = textcelular.Text;


                    if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR LOS DATOS DEL CLIENTE ?", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdminCliente.update(cCliente))
                        {
                            MessageBox.Show("CLIENTE MODIFICADO CORRECTAMENTE ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LimpiarCajas("");
                            ListarClientes();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataclientes.CurrentRow.Cells[0].Value.ToString();
                textnombre.Text = dataclientes.CurrentRow.Cells[1].Value.ToString();
                txtapellidos.Text = dataclientes.CurrentRow.Cells[2].Value.ToString();
                combosexo.Text = dataclientes.CurrentRow.Cells[3].Value.ToString();
                combodocumento.Text = dataclientes.CurrentRow.Cells[4].Value.ToString();
                txtdocumento.Text = dataclientes.CurrentRow.Cells[5].Value.ToString();
                textdireccion.Text = dataclientes.CurrentRow.Cells[6].Value.ToString();
                textcelular.Text = dataclientes.CurrentRow.Cells[7].Value.ToString();
                textemail.Text = dataclientes.CurrentRow.Cells[8].Value.ToString();
                
                tabControl1.SelectedTab = tabPage1;
                ControlCajas(true);
                ControlEditar(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
