using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsProveedor
    {
        private Int32 iCodproveedor;
        private String sRuc;
        private String sRazonsocial;
        private String sDireccion;
        private String sLocalidad;
        private String sCelular;
        private String sEmail;
        private Boolean bEstado;

        public int Codproveedor
        {
            get
            {
                return iCodproveedor;
            }

            set
            {
                iCodproveedor = value;
            }
        }

        public string Ruc
        {
            get
            {
                return sRuc;
            }

            set
            {
                sRuc = value;
            }
        }

        public string Razonsocial
        {
            get
            {
                return sRazonsocial;
            }

            set
            {
                sRazonsocial = value;
            }
        }

        public string Direccion
        {
            get
            {
                return sDireccion;
            }

            set
            {
                sDireccion = value;
            }
        }

        public string Localidad
        {
            get
            {
                return sLocalidad;
            }

            set
            {
                sLocalidad = value;
            }
        }

        public string Celular
        {
            get
            {
                return sCelular;
            }

            set
            {
                sCelular = value;
            }
        }

        public string Email
        {
            get
            {
                return sEmail;
            }

            set
            {
                sEmail = value;
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
    }
}
