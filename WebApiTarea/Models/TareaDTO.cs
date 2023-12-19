using EntityFrameworkPractica.Models;

namespace WebApiTareas.Models
{
    public class TareaDTO
    {
        
        public Guid CategoriaId { get; set; } 
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Prioridad PrioridadTarea { get; set; }
        public Estado estado { get; set; }
        public DateTime FechaCreacion { get; set; } 
         
    }
}
