using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsOrdenservicio
    {
        public Int32 iId_OS;
        public Int32 iId_cliente;
        public Int32 iId_tecnico;
        public String sEstadoservicio;
        public DateTime dFechainicial;
        public DateTime dFechafinal;
        public String sGarantia;
        public String sDescripcionProducto;
        public String sObservaciones;
        public String sDiagnostico;
        public Boolean bEstado;

        public int Id_OS
        {
            get
            {
                return iId_OS;
            }

            set
            {
                iId_OS = value;
            }
        }

        public int Id_cliente
        {
            get
            {
                return iId_cliente;
            }

            set
            {
                iId_cliente = value;
            }
        }

        public int Id_tecnico
        {
            get
            {
                return iId_tecnico;
            }

            set
            {
                iId_tecnico = value;
            }
        }

        public string Estadoservicio
        {
            get
            {
                return sEstadoservicio;
            }

            set
            {
                sEstadoservicio = value;
            }
        }

        public DateTime Fechainicial
        {
            get
            {
                return dFechainicial;
            }

            set
            {
                dFechainicial = value;
            }
        }

        public DateTime Fechafinal
        {
            get
            {
                return dFechafinal;
            }

            set
            {
                dFechafinal = value;
            }
        }

        public string Garantia
        {
            get
            {
                return sGarantia;
            }

            set
            {
                sGarantia = value;
            }
        }

        public string DescripcionProducto
        {
            get
            {
                return sDescripcionProducto;
            }

            set
            {
                sDescripcionProducto = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return sObservaciones;
            }

            set
            {
                sObservaciones = value;
            }
        }

        public string Diagnostico
        {
            get
            {
                return sDiagnostico;
            }

            set
            {
                sDiagnostico = value;
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
