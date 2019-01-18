using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    class clsMovimiento
    {
        public Int32 iCodigomovimiento;
        public Double dMonto;
        public string sDescripcion;
        public Boolean bEstado;
        public DateTime dfecha;
        public String sMovimiento;

        public int Codigomovimiento
        {
            get
            {
                return iCodigomovimiento;
            }

            set
            {
                iCodigomovimiento = value;
            }
        }

        public double Monto
        {
            get
            {
                return dMonto;
            }

            set
            {
                dMonto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return sDescripcion;
            }

            set
            {
                sDescripcion = value;
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

        public DateTime Fecha
        {
            get
            {
                return dfecha;
            }

            set
            {
                dfecha = value;
            }
        }

        public string Movimiento
        {
            get
            {
                return sMovimiento;
            }

            set
            {
                sMovimiento = value;
            }
        }
    }
}
