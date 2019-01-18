using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectServices.Entidades;
using ProjectServices.Administrador;


namespace ProjectServices.Vistas
{
    public partial class Movimiento : Form
    {
        clsMovimiento cMovimiento;
        clsAdminMovimiento AdmMovimiento = new clsAdminMovimiento();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public Movimiento()
        {
            InitializeComponent();
        }

        private void Movimiento_Load(object sender, EventArgs e)
        {
            Movimientos();
            ListarMovimientos();
            DGVmovimientos.DefaultCellStyle.Font = new Font("Century Gothic", 10);

            controlBotones(false,true);
            Controlcajas(false);
        }


        private void controlBotones(bool bandera,bool bandera1)
        {
            btnsave.Enabled = bandera;
            btnupdate.Enabled = bandera;
            btncancel.Enabled = bandera;

            btnnuevo.Enabled = bandera1;
        }

        private void CBupdate(bool bandera,bool bandera1)
        {
            btnnuevo.Enabled = bandera;
            btnsave.Enabled = bandera;

            btnupdate.Enabled = bandera1;
            btncancel.Enabled = bandera1;
        }

        private void LimpiarCajas(String bandera)
        {
            txtmonto.Text = bandera;
            comboTipo.SelectedIndex = 0;
            txtdescripcion.Text = bandera;
        }

        private void Controlcajas(bool bandera)
        {
            txtmonto.Enabled = bandera;
            txtdescripcion.Enabled = bandera;
            comboTipo.Enabled = bandera;
        }

        private void ListarMovimientos()
        {
            try
            {
                
                dt = AdmMovimiento.lista_Movimientos();
                ds.Tables.Add(dt);
                DGVmovimientos.DataSource = dt;
                MostrarDocumentos();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDocumentos()
        {
            try
            {
                DGVmovimientos.Columns[0].Visible = false;
                DGVmovimientos.Columns[5].Visible = false;

                DGVmovimientos.Columns[1].Width = 150;
                DGVmovimientos.Columns[2].Width = 150;
                DGVmovimientos.Columns[3].Width = 350;
                DGVmovimientos.Columns[4].Width = 150;

                DGVmovimientos.RowTemplate.Height = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Movimientos()
        {
            try
            {
                comboTipo.Items.Add("INGRESO");
                comboTipo.Items.Add("EGRESO");

                comboTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*Validar cajas de texto*/
        private bool isValidate()
        {
            bool no_error = true;

            if (txtmonto.Text == string.Empty)
            {
                errorProvider1.SetError(txtmonto, "Ingresar Monto porfavor");
                no_error = false;
            }
            else
            {

                if (comboTipo.SelectedIndex == -1 )
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtdescripcion, "Ingresar tipo de  movimiento porfavor");
                    return false;
                }

                if (txtdescripcion.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtdescripcion, "Ingresar descripcion  del movimiento porfavor");
                    return false;
                }

            }

            return no_error;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidate())
                {
                    cMovimiento = new clsMovimiento();

                    cMovimiento.Monto = Double.Parse(txtmonto.Text.Trim());
                    cMovimiento.Movimiento = comboTipo.SelectedItem.ToString();
                    cMovimiento.Descripcion = txtdescripcion.Text.ToUpper();

                    if (AdmMovimiento.insert(cMovimiento))
                    {
                        MessageBox.Show("MOVIMIENTO REGISTRADO CORRECTAMENTE", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListarMovimientos();
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

        private void DGVmovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtcodigo.Text = DGVmovimientos.CurrentRow.Cells[0].Value.ToString();
                txtmonto.Text = DGVmovimientos.CurrentRow.Cells[1].Value.ToString();
                comboTipo.Text = DGVmovimientos.CurrentRow.Cells[2].Value.ToString();
                txtdescripcion.Text = DGVmovimientos.CurrentRow.Cells[3].Value.ToString();

                tabControl1.SelectedTab = tabPage1;
                Controlcajas(true);
                CBupdate(false, true);
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
                cMovimiento = new clsMovimiento();

                cMovimiento.Codigomovimiento = Int32.Parse(txtcodigo.Text);
                cMovimiento.Monto = Double.Parse(txtmonto.Text.Trim());
                cMovimiento.Movimiento = comboTipo.SelectedItem.ToString();
                cMovimiento.Descripcion = txtdescripcion.Text.ToUpper();

                if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR MOVIMIENTO ? ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdmMovimiento.update(cMovimiento))
                        {
                            MessageBox.Show("MOVIMIENTO MODIFICADO CORRECTAMENTE ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        ListarMovimientos();
                        LimpiarCajas("");
                        }
                    }

                }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVmovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodigo.Text = DGVmovimientos.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            controlBotones(true, false);
            Controlcajas(true);
            btnupdate.Enabled = false;
            txtmonto.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            controlBotones(false, true);
            LimpiarCajas("");
            Controlcajas(false);
            errorProvider1.Clear();
        }
    }
}
