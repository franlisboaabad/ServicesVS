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

namespace ProjectServices.Vistas
{
    public partial class Servicio : Form
    {
        clsServicio cServicio;
        clsAdminServicio AdmServicio = new clsAdminServicio();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Servicio()
        {
            InitializeComponent();
            ListarServicio();
            Controles();
            ControlCajas(false);
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

        /*Validar cajas de texto*/
        private bool isValidate()
        {
            bool no_error = true;
            
            if (textservicio.Text == string.Empty)
            {
                errorProvider1.SetError(textservicio, "Ingresar Servicio porfavor");
                no_error = false;
            }
            else
            {
                if (textcosto.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textcosto, "Ingresar Costo de servicio porfavor");
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
            dataservicios.Columns[0].Visible = false;
            dataservicios.Columns[4].Visible = false;

            dataservicios.Columns[1].Width = 400;
            dataservicios.Columns[3].Width = 300;
            dataservicios.RowTemplate.Height = 30;
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

            ControlCajas(bandera);
        }

        /*cajas de texto*/
        private void ControlCajas(bool band)
        {
            textservicio.Enabled = band;
            textcosto.Enabled = band;
            textdescripcion.Enabled = band;
            textservicio.Select();
        }

        /*Limpiar cajas de texto*/
        private void LimpiarCajas(String band)
        {
            textservicio.Text = band;
            textcosto.Text = band;
            textdescripcion.Text = band;
        }





        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                if (isValidate())
                {
                    cServicio = new clsServicio();

                    cServicio.Servicio = textservicio.Text.ToUpper();
                    cServicio.Costo = Double.Parse(textcosto.Text);
                    cServicio.Descripcion = textdescripcion.Text.ToUpper();

                    if (AdmServicio.insert(cServicio))
                    {
                        MessageBox.Show("SERVICIO REGISTRADO CORRECTAMENTE", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListarServicio();
                        LimpiarCajas("");
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarControl(true);
            btnnuevo.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ActivarControl(false);
            btnnuevo.Enabled = true;
            errorProvider1.Clear();
            LimpiarCajas("");
        }

        private void dataservicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataservicios.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataservicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataservicios.CurrentRow.Cells[0].Value.ToString();
                textservicio.Text = dataservicios.CurrentRow.Cells[1].Value.ToString();
                textcosto.Text = dataservicios.CurrentRow.Cells[2].Value.ToString();
                textdescripcion.Text = dataservicios.CurrentRow.Cells[3].Value.ToString();

                tabControl1.SelectedTab = tabPage1;
                ControlCajas(true);
                ControlEditar(true);
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
                DialogResult resul = MessageBox.Show("¿ ESTA SEGURO DE ELIMINAR EL SERVICIO ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    cServicio = new clsServicio();

                    try
                    {
                        if (textcodigo.Text != string.Empty)
                        {

                            cServicio.CodigoServicio = Convert.ToInt32(textcodigo.Text);

                            if (AdmServicio.delete(cServicio))
                            {
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINAR REGISTRO", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ListarServicio();
                                textcodigo.Text = "";
                                checkDelete.Checked = false;
                            }

                        }
                        else
                        {
                            checkDelete.Checked = false;
                            MessageBox.Show("Seleccionar servicio a eliminar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error del sistema  : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    checkDelete.Checked = false;
                }

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cServicio = new clsServicio();

                if (isValidate())
                {
                    cServicio.CodigoServicio = Convert.ToInt32(textcodigo.Text);
                    cServicio.Servicio = textservicio.Text.ToUpper();
                    cServicio.Costo = Double.Parse(textcosto.Text);
                    cServicio.Descripcion = textdescripcion.Text.ToUpper();



                    if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR EL SERVICIO ? ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdmServicio.update(cServicio))
                        {
                            MessageBox.Show("SERVICIO MODIFICADO CORRECTAMENTE ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LimpiarCajas("");
                            ListarServicio();
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
