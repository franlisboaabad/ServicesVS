using MySql.Data.MySqlClient;
using ProjectServices.Administrador;
using ProjectServices.Conexion;
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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
       


        clsUsuario Usser = new clsUsuario();
        clsAdminUsuario AdmUsser = new clsAdminUsuario();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Login()
        {
            InitializeComponent();
            textusuario.Select();
        }

        
        private void btnAcceso_Click(object sender, EventArgs e)
        {
            try
            {
                Loguearse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Loguearse()
        {
            try
            {
                String usuario = textusuario.Text;
                String clave = textclave.Text;

                if (usuario.Equals(""))
                {
                    MessageBox.Show("Ingresar el usuario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textusuario.Focus();
                }
                if (clave.Equals(""))
                {
                    MessageBox.Show("Ingresar la clave ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textclave.Focus();
                }

                if ((usuario != string.Empty) || (clave != string.Empty))
                {
                    clsUsuario Usuario = AdmUsser.Validar_Usuario(usuario,clave);

                    if (Usuario == null)
                    {
                        MessageBox.Show("Porfavor debe ingresar sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textusuario.Focus();
                    }else
                    {
                        if (Usuario.Usuario == usuario.ToUpper() && Usuario.Clave == clave.ToUpper())
                        {
                            MessageBox.Show("B I E N V E N I D O   " + Usuario.Usuario, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Menuprincipal principal = new Menuprincipal(Usuario);
                            principal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error, debe digitar bien su clave o usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Porfavor debe ingresar sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textusuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Loguearse();
            }
        }
    }
}
