using ProjectServices.Entidades;
using System;
using System.Data;

namespace ProjectServices.Interfaces
{
    interface ICliente
    {
        Boolean Insert(clsCliente insert);//insert cliente
        Boolean Update(clsCliente update);//update cliente
        Boolean Delete(clsCliente delete);//delete cliente
        DataTable lista_cliente();//Lista de clientes
    }
}
