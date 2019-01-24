using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsDetalle_dos_producto
    {
        private Int32 iId_Detalle_os_product;
        private Int32 iId_OS;
        private Int32 iId_producto;
        private Int32 iCantidad;
        private Decimal dCosto;
        private Decimal dImporte_total;
        private Boolean bEstado;

        public int Id_Detalle_os_product
        {
            get
            {
                return iId_Detalle_os_product;
            }

            set
            {
                iId_Detalle_os_product = value;
            }
        }

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

        public decimal Costo
        {
            get
            {
                return dCosto;
            }

            set
            {
                dCosto = value;
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
