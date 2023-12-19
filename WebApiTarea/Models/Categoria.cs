using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EntityFrameworkPractica.Models
{
    public class Categoria
    {
        //[Key]
        public Guid Id { get; set; }

        //[Required]
        //[MaxLength(150)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Peso { get; set; }

        [JsonIgnore] //al momento de traer los datos, ignore las tareas para evitar error de ciclo
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
