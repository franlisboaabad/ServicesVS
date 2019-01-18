using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsCliente
    {
        private Int32 iId_Cliente;
        private String sNombre;
        private String sApellidos;
        private String sSexo;
        private DateTime dFecha_inscripcion;
        private String sTipo_documento;
        private String sDocumento;
        private String sDireccion;
        private String sCelular;
        private String sTelefono;
        private String sEmail;
        private Boolean bEstado;

        public int Id_Cliente
        {
            get
            {
                return iId_Cliente;
            }

            set
            {
                iId_Cliente = value;
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

        public DateTime Fecha_inscripcion
        {
            get
            {
                return dFecha_inscripcion;
            }

            set
            {
                dFecha_inscripcion = value;
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

        public string Telefono
        {
            get
            {
                return sTelefono;
            }

            set
            {
                sTelefono = value;
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
