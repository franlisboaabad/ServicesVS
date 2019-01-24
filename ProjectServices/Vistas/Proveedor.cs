using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


using ProjectServices.Administrador;
using ProjectServices.Entidades;


namespace ProjectServices.Vistas
{
    public partial class Proveedor : Form
    {

        clsProveedor cProveedor;
        clsAdminProveedor AdminProveedor = new clsAdminProveedor();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Proveedor()
        {
            InitializeComponent();
            ControlCajas(false);
            ListarProveedores();
            controlBotones(false);
            dataproveedor.DefaultCellStyle.Font = new Font("Century Gothic", 10);
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

        /*Validar cajas de texto*/
        private bool isValidate()
        {
            bool no_error = true;

            if (textruc.Text == string.Empty)
            {
                errorProvider1.SetError(textruc, "Ingresar RUC porfavor");
                no_error = false;
            }
            else
            {
                if (textrazonsocial.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textrazonsocial, "Ingresar Razon social porfavor");
                    return false;
                }

                if (textcelular.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textcelular, "Ingresar celular porfavor");
                    return false;
                }

           

            }

            return no_error;

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
            dataproveedor.RowTemplate.Height = 30;
        }

        /*Limpiar cajas de texto*/
        private void LimpiarCajas(String bandera)
        {
            textruc.Text = bandera;
            textrazonsocial.Text = bandera;
            textlocalidad.Text = bandera;
            textcelular.Text = bandera;
            textdireccion.Text = bandera;
            textemail.Text = bandera;
        }

        /*controlar botones*/
        private void controlBotones(bool bandera)
        {
            btnsave.Enabled = bandera;
            btnupdate.Enabled = false;
            btncancel.Enabled = bandera;
        }

        /*controlar botones update*/
        private void CBotonupdate(bool band1, bool band2)
        {
            btnnuevo.Enabled = band1;
            btnsave.Enabled = band1;
            btnupdate.Enabled = band2;
            btncancel.Enabled = band2;
        }

        /*cajas de texto*/
        private void ControlCajas(bool band)
        {
            textruc.Enabled = band;
            textrazonsocial.Enabled = band;
            textlocalidad.Enabled = band;
            textcelular.Enabled = band;
            textdireccion.Enabled = band;
            textemail.Enabled = band;
            textruc.Select();

            textruc.MaxLength = 10;
            textcelular.MaxLength = 9;
        }


        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ControlCajas(true);
            controlBotones(true);
            btnnuevo.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ControlCajas(false);
            LimpiarCajas("");
            errorProvider1.Clear();
            controlBotones(false);
            btnnuevo.Enabled = true;
        }

        /*Guardar proveedor*/
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cProveedor = new clsProveedor();

                if (isValidate())
                {
                    cProveedor.Ruc = textruc.Text;
                    cProveedor.Razonsocial = textrazonsocial.Text.ToUpper();
                    cProveedor.Direccion = textdireccion.Text.ToUpper();
                    cProveedor.Localidad = textlocalidad.Text.ToUpper();
                    cProveedor.Celular = textcelular.Text;
                    cProveedor.Email = textemail.Text.ToUpper();


                    if (AdminProveedor.insert(cProveedor))
                    {
                        MessageBox.Show("PROVEEDOR REGISTRADO CORRECTAMENTE", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListarProveedores();
                        LimpiarCajas("");
                        errorProvider1.Clear();
                        textruc.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*seleccionar y guardar ID de proveedor (oculto)*/
        private void dataproveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataproveedor.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Pasar datos de grida a las cajas de texto*/
        private void dataproveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataproveedor.CurrentRow.Cells[0].Value.ToString();
                textruc.Text = dataproveedor.CurrentRow.Cells[1].Value.ToString();
                textrazonsocial.Text = dataproveedor.CurrentRow.Cells[2].Value.ToString();
                textdireccion.Text = dataproveedor.CurrentRow.Cells[3].Value.ToString();
                textlocalidad.Text = dataproveedor.CurrentRow.Cells[4].Value.ToString();
                textcelular.Text = dataproveedor.CurrentRow.Cells[5].Value.ToString();
                textemail.Text = dataproveedor.CurrentRow.Cells[6].Value.ToString();

                tabControl1.SelectedTab = tabPage1;
                ControlCajas(true);
                CBotonupdate(false,true);
                textruc.Select();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Eliminar un proveedor */
        private void checkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDelete.Checked)
            {
                DialogResult resul = MessageBox.Show("¿ ESTA SEGURO DE ELIMINAR AL PROVEEDOR ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    cProveedor = new clsProveedor();

                    try
                    {

                        if (textcodigo.Text != string.Empty)
                        {
                            cProveedor.Codproveedor = Convert.ToInt32(textcodigo.Text);

                            if (AdminProveedor.delete(cProveedor))
                            {
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINAR REGISTRO", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ListarProveedores();
                                textcodigo.Text = "";
                                checkDelete.Checked = false;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Seleccionar proveedor a eliminar ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        /*Actualizar un proveedor*/
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cProveedor = new clsProveedor();

                if (isValidate())
                {
                    cProveedor.Codproveedor = Convert.ToInt32(textcodigo.Text);
                    cProveedor.Ruc = textruc.Text;
                    cProveedor.Razonsocial = textrazonsocial.Text.ToUpper();
                    cProveedor.Direccion = textdireccion.Text.ToUpper();
                    cProveedor.Localidad = textlocalidad.Text.ToUpper();
                    cProveedor.Celular = textcelular.Text;
                    cProveedor.Email = textemail.Text.ToUpper();


                    if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR DATOS DEL PROVEEDOR ? ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdminProveedor.update(cProveedor))
                        {
                            MessageBox.Show("PROVEEDOR MODIFICADO CORRECTAMENTE ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LimpiarCajas("");
                            ListarProveedores();
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
