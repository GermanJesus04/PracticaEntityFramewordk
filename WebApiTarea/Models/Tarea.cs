using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkPractica.Models
{

    public class Tarea
    {
        //[Key]
        public Guid TareaId { get; set; }
         
        public Guid CategoriaId { get; set; }
         
        public string Titulo { get; set; } 
        public string Descripcion { get; set; } 
        public Prioridad PrioridadTarea { get; set; } 
        public Estado estado { get; set; }
        public DateTime FechaCreacion { get; set; } 
        public virtual Categoria Categoria { get; set; }
         
        public string? Resumen { get; set; }


    }
}
