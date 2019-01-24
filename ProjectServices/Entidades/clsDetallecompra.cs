using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsDetallecompra
    {
        private Int32 iId_detallecompra;
        private Int32 iId_compra;
        private Int32 iId_producto;
        private Int32 iCantidad;
        private Decimal dPrecio_compra;
        private Decimal dImporte_total;
        private Boolean bEstado;

        public int Id_detallecompra
        {
            get
            {
                return iId_detallecompra;
            }

            set
            {
                iId_detallecompra = value;
            }
        }

        public int Id_compra
        {
            get
            {
                return iId_compra;
            }

            set
            {
                iId_compra = value;
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

        public decimal Precio_compra
        {
            get
            {
                return dPrecio_compra;
            }

            set
            {
                dPrecio_compra = value;
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
    }
}
