using ProjectServices.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectServices.Interfaces
{
    interface IServicio
    {
        bool Insert(clsServicio insert);//Insert 

        bool Update(clsServicio update);//Update

        bool Delete(clsServicio delete);//Delete

        DataTable lista_servicios();//lista
    }
}
