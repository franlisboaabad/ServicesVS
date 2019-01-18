using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectServices.Entidades;
using System.Data;

namespace ProjectServices.Interfaces
{
    interface IProducto
    {
        Boolean Insert(clsProducto Insert);//Insertar
        Boolean Update(clsProducto update);//Update
        Boolean Delete(clsProducto delete);//delete
        DataTable ListaProductos();
    }
}
