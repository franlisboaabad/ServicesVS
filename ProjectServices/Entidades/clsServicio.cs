using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    public class clsServicio
    {
        private Int32 iCodigoServicio;
        private String sServicio;
        private Double dCosto;
        private String sDescripcion;
        private Boolean bEstado;

        
        public int CodigoServicio
        {
            get
            {
                return iCodigoServicio;
            }

            set
            {
                iCodigoServicio = value;
            }
        }

        public string Servicio
        {
            get
            {
                return sServicio;
            }

            set
            {
                sServicio = value;
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

        public double Costo
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
    }
}
