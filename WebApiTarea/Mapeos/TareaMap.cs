using AutoMapper;
using EntityFrameworkPractica.Models;
using WebApiTareas.Models;

namespace WebApiTareas.Mapeos
{
    public class TareaMap : Profile
    {
        public TareaMap()
        {
            CreateMap<TareaDTO, Tarea>().ReverseMap();
        }
    }
}
