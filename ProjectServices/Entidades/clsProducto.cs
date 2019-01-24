using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsProducto
    {
        private Int32 iCodproducto;
        private String sNombre;
        private Int32 iCodcategoria;
        private String sMarca;
        private String sModelo;
        private String sDescripcion;
        private Int32 iExistencias;
        private Double dPrecioventa;
        private Boolean bEstado;
        public byte[] bImagen;

        //Formproducto -- Add
        private Int32 iCantidad;
        private Double iSubtotal;

        public byte[] Imagen { get { return bImagen; } set { bImagen = value; } }


        public int Codproducto
        {
            get
            {
                return iCodproducto;
            }

            set
            {
                iCodproducto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return sNombre;
            }

            set
            {
                sNombre = value;
            }
        }

        public int Codcategoria
        {
            get
            {
                return iCodcategoria;
            }

            set
            {
                iCodcategoria = value;
            }
        }

        public string Marca
        {
            get
            {
                return sMarca;
            }

            set
            {
                sMarca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return sModelo;
            }

            set
            {
                sModelo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return sDescripcion;
            }

            set
            {
                sDescripcion = value;
            }
        }

        public int Existencias
        {
            get
            {
                return iExistencias;
            }

            set
            {
                iExistencias = value;
            }
        }

        public double Precioventa
        {
            get
            {
                return dPrecioventa;
            }

            set
            {
                dPrecioventa = value;
            }
        }

        public bool Estado
        {
            get
            {
                return bEstado;
            }

            set
            {
                bEstado = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return iCantidad;
            }

            set
            {
                iCantidad = value;
            }
        }

        public double Subtotal
        {
            get
            {
                return iSubtotal;
            }

            set
            {
                iSubtotal = value;
            }
        }
    }
}
