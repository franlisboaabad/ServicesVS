using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectServices.Entidades;
using System.Data;

namespace ProjectServices.Interfaces
{
    interface IUsuario
    {
        Boolean Insert(clsUsuario insert);//Insertar trabajador
        Boolean Update(clsUsuario update);//Update
        Boolean Delete(clsUsuario delete);//Delete
        DataTable lista_Usuario();//lista Trabajador Usuario
    }
}
