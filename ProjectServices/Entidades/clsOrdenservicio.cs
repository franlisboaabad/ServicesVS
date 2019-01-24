using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsOrdenservicio
    {
        private Int32 iId_OS;
        private Int32 iId_cliente;
        private Int32 iId_tecnico;
        private String sEstadoservicio;
        private DateTime dFechainicial;
        private DateTime dFechafinal;
        private String sGarantia;
        private String sDescripcionProducto;
        private String sObservaciones;
        private String sDiagnostico;
        private Decimal dImporte_total;
        private String sTipo_pago;
        private Decimal dPago;
        private Decimal dVuelto;
        private Decimal dSaldo;
        private Boolean bEstado;

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

        public decimal Importe_total
        {
            get
            {
                return dImporte_total;
            }

            set
            {
                dImporte_total = value;
            }
        }

        public string Tipo_pago
        {
            get
            {
                return sTipo_pago;
            }

            set
            {
                sTipo_pago = value;
            }
        }

        public decimal Pago
        {
            get
            {
                return dPago;
            }

            set
            {
                dPago = value;
            }
        }

        public decimal Vuelto
        {
            get
            {
                return dVuelto;
            }

            set
            {
                dVuelto = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return dSaldo;
            }

            set
            {
                dSaldo = value;
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
