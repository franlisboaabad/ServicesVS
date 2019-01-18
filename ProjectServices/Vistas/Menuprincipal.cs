using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectServices.Vistas
{
    public partial class Menuprincipal : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;
        

        public Menuprincipal()
        {
            InitializeComponent();
            ChangeColor();
            toolhora.Text = DateTime.Now.ToString("G");

            Ini();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void Ini()
        {
            try
            {
                Listas.Estadisticas e = new Listas.Estadisticas();
                e.MdiParent = this;

                e.Show();
            }
            catch (Exception)
            {

              
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
               if (Application.OpenForms["Categoria"] != null)
            {
                Application.OpenForms["Categoria"].Activate();
            }
            else
            {
                Categoria c = new Categoria();
                c.MdiParent = this;
                c.Show();
            }

          
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Cliente"] != null)
            {
                Application.OpenForms["Cliente"].Activate();
            }
            else
            {
                Cliente form = new Cliente();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Servicio"] != null)
            {
                Application.OpenForms["Servicio"].Activate();
            }
            else
            {
                Servicio form = new Servicio();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void brindarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Servicios"] != null)
            {
                Application.OpenForms["Servicios"].Activate();
            }
            else
            {
                Servicios form = new Servicios();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Proveedor"] != null)
            {
                Application.OpenForms["Proveedor"].Activate();
            }
            else
            {
                Proveedor form = new Proveedor();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Usuarios"] != null)
            {
                Application.OpenForms["Usuarios"].Activate();
            }
            else
            {
                Usuarios form = new Usuarios();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Producto"] != null)
            {
                Application.OpenForms["Producto"].Activate();
            }
            else
            {
                Producto form = new Producto();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process calc = new Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();

            calc.WaitForExit();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Configuracion"] != null)
            {
                Application.OpenForms["Configuracion"].Activate();
            }
            else
            {
                Configuracion form = new Configuracion();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void ChangeColor()
        {

            try
            {
                MdiClient ctlMDI;

                foreach (Control ctl in this.Controls)
                {
                    try
                    {
                        ctlMDI = (MdiClient)ctl;
                        //Color c = Color.LightSeaGreen;
                        Color c = Color.LightBlue;
                        ctlMDI.BackColor = c;
                    }
                    catch (Exception)
                    {

                        
                    }
                }
            }
            catch (Exception)
            {

                
            }


        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Movimiento"] != null)
            {
                Application.OpenForms["Movimiento"].Activate();
            }
            else
            {
                Movimiento form = new Movimiento();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Ventas"] != null)
            {
                Application.OpenForms["Ventas"].Activate();
            }
            else
            {
                Ventas form = new Ventas();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
