using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsCompra
    {
        private Int32 iId_compra;
        private Int32 iId_proveedor;
        private Int32 iId_usuario;
        private Decimal dImporte_total;
        private DateTime dFecha_registro;
        private String sDocumento;
        private String sNumero_documento;
        private Boolean bEstado;


        private String sTipo_pago;
        private Decimal dPago;
        private Decimal dSaldo;

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

        public int Id_proveedor
        {
            get
            {
                return iId_proveedor;
            }

            set
            {
                iId_proveedor = value;
            }
        }

        public int Id_usuario
        {
            get
            {
                return iId_usuario;
            }

            set
            {
                iId_usuario = value;
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

        public string Numero_documento
        {
            get
            {
                return sNumero_documento;
            }

            set
            {
                sNumero_documento = value;
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
    }
}
