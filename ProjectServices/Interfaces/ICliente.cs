using ProjectServices.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
