using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProjectServices.Class
{
    class clsValidacion
    {

        public void SoloTexto(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void SoloTextyNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) ||
                    Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Informacion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message, "Informacion", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }


        //convertir binario a imagen
        public Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }


        //convertir Imagen a binario
        public byte[] Convertir_Imagen_Bytes(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

    }
}
