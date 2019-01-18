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
    public partial class Usuarios : Form
    {
        clsUsuario cUsuario;
        clsAdminUsuario AdmUsuario = new clsAdminUsuario();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Usuarios()
        {
            InitializeComponent();
            ActivarNuevo(false);
            ActivarCajas(false);
            sexo();
            ListaUsuarios();
            dataUsuarios.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            
        }

  
        public void sexo()
        {
            combosexo.Items.Add("Seleccione sexo");
            combosexo.Items.Add("Masculino");
            combosexo.Items.Add("Femenino");
            combosexo.SelectedIndex = 0;
        }

        private void LimpiarCajasdetexto()
        {
            textnombres.Text = "";
            textapellidos.Text = "";
            combosexo.SelectedIndex = 0;
            textdocumento.Text = "";
            textdireccion.Text = "";
            textcelular.Text = " ";
            textemail.Text = "";
            textusuario.Text = "";
            textcontraseña.Text = "";
        }

       

        private bool isValidate()
        {
            bool no_error = true;

            if (textnombres.Text == string.Empty)
            {
                errorProvider1.SetError(textnombres, "Ingresar nombre porfavor");
                no_error = false;
            }
            else
            {
                if (textusuario.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textusuario, "Ingresar usuario porfavor");
                    return false;
                }

                if (textdocumento.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textdocumento, "Ingresar numero de documento porfavor");
                    return false;
                }

                if (textcontraseña.Text == string.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textcontraseña, "Ingresar contraeña porfavor");
                    return false;
                }

            }

            return no_error;

        }


        private void ActivarCajas(bool bandera)
        {
            textnombres.Enabled = bandera;
            textapellidos.Enabled = bandera;
            combosexo.Enabled = bandera;
            textdocumento.Enabled = bandera;
            textdireccion.Enabled = bandera;
            textcelular.Enabled = bandera;
            textemail.Enabled = bandera;
            textusuario.Enabled = bandera;
            textcontraseña.Enabled = bandera;
            dtpfecha.Enabled = bandera;
        }
        private void ActivarNuevo(bool bandera)
        {
            btnsave.Enabled = bandera;
            btncancel.Enabled = bandera;
            btnupdate.Enabled = false;
        }
        private void ControlEditar(bool bandera)
        {
            btncancel.Enabled = bandera;
            btnupdate.Enabled = bandera;
            btnnuevo.Enabled = false;
        }

      

        private void ListaUsuarios()
        {
            try
            {
                dt = AdmUsuario.lista_Usuarios();
                ds.Tables.Add(dt);
                dataUsuarios.DataSource = dt;

                dataUsuarios.Columns[1].Width = 150;
                dataUsuarios.Columns[2].Width = 150;
                dataUsuarios.Columns[3].Width = 150;
                dataUsuarios.Columns[4].Width = 150;
                dataUsuarios.Columns[5].Width = 150;
                dataUsuarios.Columns[6].Width = 150;
                dataUsuarios.Columns[7].Width = 150;
                dataUsuarios.Columns[8].Width = 150;
                dataUsuarios.Columns[9].Width = 150;
                dataUsuarios.Columns[10].Width = 150;




                dataUsuarios.Columns[0].Visible = false;
                dataUsuarios.Columns[11].Visible = false;
                dataUsuarios.RowTemplate.Height = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cUsuario = new clsUsuario();

                if (isValidate())
                {
                    cUsuario.Nombre = textnombres.Text.ToUpper();
                    cUsuario.Apellidos = textapellidos.Text.ToUpper();
                    cUsuario.Fecha_nacimiento = DateTime.Parse( dtpfecha.Text.ToString() );
                    cUsuario.Sexo = combosexo.SelectedItem.ToString();
                    cUsuario.Documento = textdocumento.Text.ToUpper();
                    cUsuario.Direccion = textdireccion.Text.ToUpper();
                    cUsuario.Celular = textcelular.Text.ToUpper();
                    cUsuario.Email = textemail.Text.ToUpper();
                    cUsuario.Usuario = textusuario.Text.ToUpper();
                    cUsuario.Clave = textcontraseña.Text.ToUpper();

                    if (AdmUsuario.insert(cUsuario))
                    {
                        MessageBox.Show("USUARIO REGISTRADO CORRECTAMENTE", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListaUsuarios();
                        LimpiarCajasdetexto();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarNuevo(true);
            ActivarCajas(true);
            textnombres.Select();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            LimpiarCajasdetexto();
            ActivarNuevo(false);
            ActivarCajas(false);
            btnnuevo.Enabled = true;
            errorProvider1.Clear();
        }

        private void dataUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataUsuarios.CurrentRow.Cells[0].Value.ToString();
                textnombres.Text = dataUsuarios.CurrentRow.Cells[1].Value.ToString();
                textapellidos.Text = dataUsuarios.CurrentRow.Cells[2].Value.ToString();
                combosexo.Text = dataUsuarios.CurrentRow.Cells[3].Value.ToString();
                dtpfecha.Text =  dataUsuarios.CurrentRow.Cells[4].Value.ToString();
                textdocumento.Text = dataUsuarios.CurrentRow.Cells[5].Value.ToString();
                textdireccion.Text = dataUsuarios.CurrentRow.Cells[6].Value.ToString();
                textcelular.Text = dataUsuarios.CurrentRow.Cells[7].Value.ToString();
                textemail.Text = dataUsuarios.CurrentRow.Cells[8].Value.ToString();
                textusuario.Text = dataUsuarios.CurrentRow.Cells[9].Value.ToString();
                textcontraseña.Text = dataUsuarios.CurrentRow.Cells[10].Value.ToString();


                tabControl1.SelectedTab = tabPage1;
                ActivarCajas(true);
                ControlEditar(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textcodigo.Text = dataUsuarios.CurrentRow.Cells[0].Value.ToString();
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
                cUsuario = new clsUsuario();                               

                if (isValidate())
                {
                    cUsuario.Id_Trabajador = Int32.Parse(textcodigo.Text);
                    cUsuario.Nombre = textnombres.Text.ToUpper();
                    cUsuario.Apellidos = textapellidos.Text.ToUpper();
                    cUsuario.Fecha_nacimiento = DateTime.Parse(dtpfecha.Text.ToString());
                    cUsuario.Sexo = combosexo.SelectedItem.ToString();
                    cUsuario.Documento = textdocumento.Text.ToUpper();
                    cUsuario.Direccion = textdireccion.Text.ToUpper();
                    cUsuario.Celular = textcelular.Text.ToUpper();
                    cUsuario.Email = textemail.Text.ToUpper();
                    cUsuario.Usuario = textusuario.Text.ToUpper();
                    cUsuario.Clave = textcontraseña.Text.ToUpper();

                    if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR USUARIO ? ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdmUsuario.update(cUsuario))
                        {
                            MessageBox.Show("USUARIO MODIFICADO CORRECTAMENTE", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListaUsuarios();
                            LimpiarCajasdetexto();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chekeliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chekeliminar.Checked)
            {
                DialogResult resul = MessageBox.Show("¿ ESTA SEGURO DE ELIMINAR EL USUARIO ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    cUsuario = new clsUsuario();

                    try
                    {
                        if (textcodigo.Text != string.Empty)
                        {
                            cUsuario.Id_Trabajador = Convert.ToInt32(textcodigo.Text);

                            if (AdmUsuario.delete(cUsuario))
                            {
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINAR REGISTRO", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ListaUsuarios();
                                textcodigo.Text = "";
                                chekeliminar.Checked = false;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Seleccionar usuario a eliminar" , "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chekeliminar.Checked = false;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    chekeliminar.Checked = false;
                }

            }
        }
    }
}
