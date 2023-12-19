using EntityFrameworkPractica.Models;
//using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractica.Repository
{
    public class ApplicationDbContext//: DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opcions) : base(opcions) { }

        //public DbSet<Tarea> Tareas { get; set; }
        //public DbSet<Categoria> Categorias { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    List<Categoria> catList = new List<Categoria>()
        //    { new Categoria {
        //        Id = Guid.Parse("b42e736c-c244-4437-b1bd-d83478bf5eba"),
        //        Nombre = "Castellano",
        //        //Descripcion = "lorem imsu",
        //        Peso = 34
        //       },
        //       new Categoria {
        //        Id = Guid.Parse("7ba6f1a8-89ec-494a-9572-38483e6ed975"),
        //        Nombre = "Matematica",
        //        Descripcion = "lorem imsu",
        //        Peso = 26
        //       }
        //    };

        //    List<Tarea> tareaList = new List<Tarea>()
        //    {
        //        new Tarea {
        //        TareaId = Guid.Parse("46ab40aa-52ee-4062-ade9-8c4282af4300"),
        //        CategoriaId =  Guid.Parse("b42e736c-c244-4437-b1bd-d83478bf5eba"),
        //        Titulo= "investigacion",
        //        PrioridadTarea = Prioridad.Media,
        //        FechaCreacion = DateTime.UtcNow,
        //        estado = Estado.ToDo,
        //       },
        //       new Tarea {
        //        TareaId = Guid.Parse("b04b9470-fb4c-467e-b151-6ca718d6094f"),
        //        CategoriaId =  Guid.Parse("7ba6f1a8-89ec-494a-9572-38483e6ed975"),
        //        Titulo= "diagrama",
        //        PrioridadTarea = Prioridad.Baja,
        //        estado = Estado.EnProgreso,
        //        FechaCreacion = DateTime.UtcNow
        //       }
        //    };

        //    modelBuilder.Entity<Categoria>(categoria =>
        //    {
        //        categoria.ToTable(name:"CATEGORIA", schema:"SISTEMA_TAREAS");
        //        categoria.HasKey(propiedad => propiedad.Id);
        //        categoria.Property(propiedad => propiedad.Nombre).IsRequired().HasMaxLength(150);
        //        categoria.Property(propiedad => propiedad.Descripcion).IsRequired(false);
        //        categoria.Property(propiedad => propiedad.Peso);
        //        //categoria.HasData(catList);
        //    });
             
        //    modelBuilder.Entity<Tarea>(tarea =>
        //    {
        //        tarea.ToTable(name:"TAREA",schema: "SISTEMA_TAREAS");
        //        tarea.HasKey(key=>key.TareaId);

        //        //una tarea tiene una categoria, y la categoria tiene muchas tareas.
        //        tarea.HasOne(una => una.Categoria).WithMany(muchas => muchas.Tareas)
        //             .HasForeignKey(p => p.CategoriaId).OnDelete(DeleteBehavior.Cascade);

        //        tarea.Property(propiedad => propiedad.Titulo).IsRequired().HasMaxLength(200);
        //        tarea.Property(propiedad => propiedad.Descripcion).IsRequired(false);
        //        tarea.Property(propiedad => propiedad.PrioridadTarea);
        //        tarea.Property(propiedad => propiedad.estado);
        //        tarea.Property(propiedad => propiedad.FechaCreacion).IsRequired();
        //        tarea.Ignore(propiedad => propiedad.Resumen);

        //        //tarea.HasData(tareaList);
        //    });
        //}

    }
}
