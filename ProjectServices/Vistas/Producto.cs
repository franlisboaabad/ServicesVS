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
using ProjectServices.Interfaces;
using ProjectServices.InterMysql;
using ProjectServices.Class;

namespace ProjectServices.Vistas
{
    public partial class Producto : Form
    {
        clsAdminCategoria AdmCategoria = new clsAdminCategoria();

        clsAdminProducto AdmProducto = new clsAdminProducto();
        clsProducto cProducto;
        clsValidacion cvalidar = new clsValidacion();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public Producto()
        {
            InitializeComponent();
            this.CategoriaCombo();
            ActivarControles(false);
            ControlCajas(false);
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10);
            ListaProductos();
        }

        private void ActivarControles(bool bandera)
        {
            btnsave.Enabled = bandera;
            btnupdate.Enabled = bandera;
            btncancel.Enabled = bandera;
            btnSeleccionar.Enabled = bandera;
        }

        private void ActivarControl(bool bandera)
        {
            btnsave.Enabled = bandera;
            btnupdate.Enabled = false;
            btncancel.Enabled = bandera;
            btnSeleccionar.Enabled = bandera;
            ControlCajas(true);
            textnombre.Focus();
        }

        private void ControlEditar(bool bandera)
        {
            btnupdate.Enabled = bandera;
            btnnuevo.Enabled = false;
            btncancel.Enabled = true;
            btnsave.Enabled = false;
        }

        private void ControlCajas(bool band)
        {
            textnombre.Enabled = band;
            textdescripcion.Enabled = band;
            combocategoria.Enabled = band;
            textdescripcion.Enabled = band;
            textexistencias.Enabled = band;
            textmarca.Enabled = band;
            textmodelo.Enabled = band;
            textprecioventa.Enabled = band;
            textnombre.Select();
        }

        private void LimpiarCajas(String cadena)
        {
            try
            {
                textnombre.Text = cadena;
                textmarca.Text = cadena;
                textmodelo.Text = cadena;
                textdescripcion.Text = cadena;
                textexistencias.Text = cadena;
                textprecioventa.Text = cadena;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool isValidate()
        {
            bool no_error = true;

            if (textnombre.Text == string.Empty)
            {
                errorProvider1.SetError(textnombre, "Ingresar nombre de producto");
                no_error = false;
            }
            else
            {
                try
                {
                    int existencia = Convert.ToInt32(textexistencias.Text);
                }
                catch
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textexistencias, "Ingrese existencias del producto");
                    return false;
                }

                try
                {
                    double precioventa = Convert.ToDouble(textprecioventa.Text);
                }
                catch
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(textprecioventa, "Ingrese precio de venta del producto");
                    return false;
                }
            }

            return no_error;

        }


        private void ListaProductos()
        {
            try
            {
                dt = AdmProducto.lista_Productos();
                ds.Tables.Add(dt);
                dataGridView1.DataSource = dt;
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
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[8].Width = 400;
            dataGridView1.RowTemplate.Height = 30;
        }



        private void CategoriaCombo()
        {
            /*Lista categoria en combobox*/
            try
            {
                combocategoria.DataSource = AdmCategoria.list_Categoria();
                combocategoria.DisplayMember = "Nombre";
                combocategoria.ValueMember = "Id_Categoria";
                combocategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message + " Posiblemente no cuenta con categorias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Title = "Open an Image File";
                Open.Filter = "JPG files (*.jpg)|*.jpg";
                //| PNG files (*.png)|*.png";

                if (Open.ShowDialog() == DialogResult.OK)
                {
                    pictureproducto.Image = Image.FromFile(Open.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cProducto = new clsProducto();

                if (isValidate())
                {
                    cProducto.Nombre = textnombre.Text.ToUpper();
                    cProducto.Codcategoria = Convert.ToInt32(combocategoria.SelectedValue);
                    cProducto.Marca = textmarca.Text.ToUpper();
                    cProducto.Modelo = textmodelo.Text.ToUpper();
                    cProducto.Descripcion = textdescripcion.Text.ToUpper();
                    cProducto.Existencias = Convert.ToInt32(textexistencias.Text.ToString());
                    cProducto.Precioventa = Convert.ToDouble(textprecioventa.Text.ToString());
                    cProducto.Imagen = cvalidar.Convertir_Imagen_Bytes(pictureproducto.Image);

                    if (AdmProducto.insert(cProducto))
                    {
                        MessageBox.Show("SE REGISTRO CORRECTAMENTE EL PRODUCTO", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        LimpiarCajas("");
                        ListaProductos();
                    }
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarControl(true);
            ControlCajas(true);
            LimpiarCajas("");
            btnnuevo.Enabled = false;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ControlCajas(false);
            ActivarControl(false);
            ControlCajas(false);
            btnnuevo.Enabled = true;
            errorProvider1.Clear();
            LimpiarCajas("");
        }

        private void CheckEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckEliminar.Checked)
            {
                DialogResult resul = MessageBox.Show("¿ ESTA SEGURO DE ELIMINAR EL PRODUCTO ?", "ELIMINAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    cProducto = new clsProducto();

                    try
                    {
                        if (textcodigo.Text != string.Empty)
                        {
                            cProducto.Codproducto = Convert.ToInt32(textcodigo.Text);

                            if (AdmProducto.Delete(cProducto))
                            {
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINAR REGISTRO", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ListaProductos();
                                textcodigo.Text = "";
                                CheckEliminar.Checked = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccionar producto a eliminar  ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            CheckEliminar.Checked = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error del sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    CheckEliminar.Checked = false;
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
                
                textnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                combocategoria.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textmarca.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textmodelo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textexistencias.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textprecioventa.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textdescripcion.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                byte[] datos = (byte[])dataGridView1.CurrentRow.Cells[9].Value; 
                pictureproducto.Image = cvalidar.Convertir_Bytes_Imagen(datos);
                tabControl1.SelectedTab = tabPage1;

                btnSeleccionar.Enabled = true;
                ControlCajas(true);
                ControlEditar(true);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cProducto = new clsProducto();

                if (isValidate())
                {
                    cProducto.Codproducto = Convert.ToInt32(textcodigo.Text);
                    cProducto.Nombre = textnombre.Text.ToUpper();
                    cProducto.Codcategoria = Convert.ToInt32(combocategoria.SelectedValue);
                    cProducto.Marca = textmarca.Text.ToUpper();
                    cProducto.Modelo = textmodelo.Text.ToUpper();
                    cProducto.Descripcion = textdescripcion.Text.ToUpper();
                    cProducto.Existencias = Convert.ToInt32(textexistencias.Text.ToString());
                    cProducto.Precioventa = Convert.ToDouble(textprecioventa.Text.ToString());
                    cProducto.Imagen = cvalidar.Convertir_Imagen_Bytes(pictureproducto.Image);

                    if (MessageBox.Show("¿ ESTA SEGURO DE MODIFICAR PRODUCTO ? ", "CONFIRMAR ACTUALIZACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (AdmProducto.update(cProducto))
                        {
                            MessageBox.Show("SE MODIFICO CORRECTAMENTE EL PRODUCTO", "CONFIRMAR REGISTRO", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LimpiarCajas("");
                            ListaProductos();
                        }
                    }
                        
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de sistema : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

