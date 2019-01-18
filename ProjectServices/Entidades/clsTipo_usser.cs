using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    class clsTipo_usser
    {
        public Int32 iTipo_usser;
        public String sDescripcion;

        public int Tipo_usser
        {
            get
            {
                return iTipo_usser;
            }

            set
            {
                iTipo_usser = value;
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
    }
}
