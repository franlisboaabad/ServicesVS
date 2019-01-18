using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Entidades
{
    class clsCategoria
    {
        private Int32 iId_Categoria;
        private String sNombre;
        private String sDescripcion;
        private Boolean bEstado;

        public int Id_Categoria
        {
            get
            {
                return iId_Categoria;
            }

            set
            {
                iId_Categoria = value;
            }
        }

        public string Nombre
        {
            get
            {
                return sNombre;
            }

            set
            {
                sNombre = value;
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
    }
}
