using System;
using System.Collections.Generic;
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
