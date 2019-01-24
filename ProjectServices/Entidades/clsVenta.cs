using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    class clsVenta
    {
        private Int32 iId_venta;
        private Int32 iId_vendedor;
        private Int32 iId_cliente;
        private DateTime dFecha_registro;
        private Decimal dImporte_total;
        private Decimal dPago;
        private Decimal dVuelto;
        private Boolean bEstado;

        public int Id_venta
        {
            get
            {
                return iId_venta;
            }

            set
            {
                iId_venta = value;
            }
        }

        public int Id_vendedor
        {
            get
            {
                return iId_vendedor;
            }

            set
            {
                iId_vendedor = value;
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

        public DateTime Fecha_registro
        {
            get
            {
                return dFecha_registro;
            }

            set
            {
                dFecha_registro = value;
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
