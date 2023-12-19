//using AutoMapper;
using EntityFrameworkPractica.Models;
using EntityFrameworkPractica.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
using WebApiTareas.Mapeos;
using WebApiTareas.Models;

namespace WebApiTareas.Controllers
{
    [Route("[controller]")]
    [ApiController, Produces("application/json")]
    public class TareassController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        //private readonly IMapper _mapeo;
        public TareassController(ApplicationDbContext context /*, IMapper mapeo*/)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            //_mapeo = mapeo;
        }
         
        [HttpGet("ListarTareas")]
        public async Task<ActionResult> Consultar()
        {
            var resp = _context.Tareas.ToList();
            return Ok(resp);
        }

        [HttpGet("ConsultarPorId")]
        public async Task<ActionResult> ConsultarPorId(Guid id)
        {
            var resp = await _context.Tareas.FindAsync(id);
            return Ok(resp);
        }

        [HttpGet("TareasConFlitro")]
        public async Task<ActionResult> TareasConFlitro()
        {
            try
            {
                var resp = _context.Tareas.Include(p => p.Categoria)
                    .Where(p => p.PrioridadTarea == Prioridad.Baja)
                    .Where(p => p.estado == Estado.EnProgreso).ToList();
                
                return Ok(resp);
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("CrearTarea")]
        public async Task<ActionResult> CrearTarea([FromBody] TareaDTO tareadto)
        {
            try
            {
                //var validarCat = await _context.Categorias.FindAsync(tareadto.CategoriaId);
                //if (validarCat == null)
                //    throw new Exception("No existe categoria para esa tarea");

                //var tarea = _mapeo.Map<Tarea>(tareadto);
                //tarea.TareaId = Guid.NewGuid();
                //tarea.FechaCreacion = DateTime.UtcNow;
                //await _context.AddAsync(tarea);
                //await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("EdtarTarea")]
        public async Task<ActionResult> EditarTarea(Guid id,[FromBody] TareaDTO tareadto)
        {
            try
            {
                //consultamos y validar tarea existe
                var tareaActual = await _context.Tareas.FindAsync(id);
                if (tareaActual is null)
                    throw new Exception("No existe categoria para esa tarea");
                 

                //mapeamos la info que esta en el dto y se la pasamos a la entidad modificando los valores
                //var config = new MapperConfiguration(cfg => cfg.AddProfile<TareaMap>());
                //var mapper = new Mapper(config);
                //mapper.Map(tareadto, tareaActual);
                 
                ////actualizamos
                //_context.Tareas.Update(tareaActual);
                //await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("EliminarTarea")]
        public async Task<ActionResult> EliminarTarea(Guid id)
        {
            try
            {
                //consultamos y validar tarea existe
                var tareaActual = await _context.Tareas.FindAsync(id);
                if (tareaActual is null)
                    throw new Exception("No existe categoria para esa tarea");

                //actualizamos
                //_context.Tareas.Remove(tareaActual);
                //await _context.SaveChangesAsync();

                return Ok($"Tarea {tareaActual.Titulo} eliminada con exito");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
