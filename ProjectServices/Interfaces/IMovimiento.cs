using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Entidades;
using System.Data;

namespace ProjectServices.Interfaces
{
    interface IMovimiento 
    {
        Boolean Insert(clsMovimiento Insert);//Insertar
        Boolean Update(clsMovimiento Update);//Insertar
        DataTable lista_Movimientos();//Lista de categorias
    }
}
