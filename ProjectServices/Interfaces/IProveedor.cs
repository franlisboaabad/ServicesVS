using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Entidades;
using System.Data;

namespace ProjectServices.Interfaces
{
    interface IProveedor
    {
        Boolean Insert(clsProveedor insert);//Insertar Proveedor
        Boolean Update(clsProveedor update);//Insertar Proveedor
        Boolean Delete(clsProveedor delete);//Insertar Proveedor
        DataTable ListaProveedor();//Lista de proveedor
    }
}
