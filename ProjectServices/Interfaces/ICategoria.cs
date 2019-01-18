using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ProjectServices.Entidades;

namespace ProjectServices.Interfaces
{
    interface ICategoria
    {
        Boolean Insert(clsCategoria Insert);//Insertar
        Boolean Update(clsCategoria Update);//Actualizar
        Boolean Delete(clsCategoria Delete);//Eliminar
        DataTable lista_Categorias();//Lista de categorias
        DataTable listaproductocate(clsCategoria categoria);
        List<clsCategoria> list_Categoria();
    }
}
