using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    class clsDetalleventa
    {

        private Int32 iId_venta;
        private Int32 iId_detalleventa;
        private Int32 iId_producto;
        private Int32 iCantidad;
        private Decimal dPrecio_venta;
        private Decimal dImporte_total;
        private Boolean bEstado;

        public int Id_detalleventa
        {
            get
            {
                return iId_detalleventa;
            }

            set
            {
                iId_detalleventa = value;
            }
        }

        public int Id_producto
        {
            get
            {
                return iId_producto;
            }

            set
            {
                iId_producto = value;
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

        public decimal Precio_venta
        {
            get
            {
                return dPrecio_venta;
            }

            set
            {
                dPrecio_venta = value;
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
    }
}
