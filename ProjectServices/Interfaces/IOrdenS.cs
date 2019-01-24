using ProjectServices.Entidades;
using System.Data;

namespace ProjectServices.Interfaces
{
    interface IOrdenS
    {
        bool Insert(clsOrdenservicio insert);//Insert
        DataTable Lista_ordenservicio(string nombre,string apellidos);//Buscar ordenservicio nombre o apellidos
        DataTable Listar_ordenservicio();//Listar orden_servicio / todas
        bool Anular_ordenservicio(int codigo);//anular orden_servicio
        DataTable Listar_ordenes_pendientes();//Listar ordenes_os_pendiente
    }
}
