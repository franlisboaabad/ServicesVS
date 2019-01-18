using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsUsuario
    {
        private Int32 iId_Trabajador;
        private String sNombre;
        private String sApellidos;
        private String sSexo;
        private DateTime dFecha_nacimiento;
        private String sTipo_documento;
        private String sDocumento;
        private String sDireccion;
        private String sCelular;
        private String sEmail;
        private Boolean bEstado;
        private String sUsuario;
        private String sClave;

        public int Id_Trabajador
        {
            get
            {
                return iId_Trabajador;
            }

            set
            {
                iId_Trabajador = value;
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

        public string Apellidos
        {
            get
            {
                return sApellidos;
            }

            set
            {
                sApellidos = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sSexo;
            }

            set
            {
                sSexo = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return dFecha_nacimiento;
            }

            set
            {
                dFecha_nacimiento = value;
            }
        }

        public string Tipo_documento
        {
            get
            {
                return sTipo_documento;
            }

            set
            {
                sTipo_documento = value;
            }
        }

        public string Documento
        {
            get
            {
                return sDocumento;
            }

            set
            {
                sDocumento = value;
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

        public string Usuario
        {
            get
            {
                return sUsuario;
            }

            set
            {
                sUsuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return sClave;
            }

            set
            {
                sClave = value;
            }
        }
    }
}
