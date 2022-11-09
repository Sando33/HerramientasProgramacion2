using api_autores.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace api_autores.Controllers
{
    //dinciamos que es un controlador
    [ApiController]
    //es definir la ruta de acceso al controlador
    [Route("api-autores/autor")]
    //: ControllerBase es una herencia para que sea un controlador
    public class AutorController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        //creamos el metodo constructor
        public AutorController(ApplicationDBContext context)
        {
            this.context = context;
        }

        //cuando queremos obtener informacion
        [HttpGet]
        public async Task<ActionResult<List<Autor>>> findAll()
        {
            return await context.Autor.ToListAsync();
        }

        //cuando queremos obtener solo los habilitados
        [HttpGet("custom")]
        public async Task<ActionResult<List<Autor>>> findAllCustom()
        {
            return await context.Autor.Where(x=> x.estado==true).ToListAsync();
        }

        //cuando queremos guardar informacion
        [HttpPost]
        public async Task<ActionResult> add(Autor a)
        {
            context.Add(a);
            await context.SaveChangesAsync();
            return BadRequest("Se Guardo correctamente");
        }
        //cuando queremos Buscar informacion
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Autor>> findById(int id)
        {
            var autor = await context.Autor
                .FirstOrDefaultAsync(x => x.codigoautor == id);
            return autor;
        }
        //cuando queremos actualizar informacion
        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Autor a, int id)
        {
            if (a.codigoautor != id)
            {
                return BadRequest("No se encontro el codigo correspondiente");
            }
            context.Update(a);
            await context.SaveChangesAsync();
            return BadRequest("Se actualizo correctamente");
        }

        // Con ese lo borras en la base de datos
         /*[HttpDelete("{id:int}")]
         public async Task<ActionResult> delete(int id)
        {
        var existe = await context.Autor.AnyAsync(x => x.codigo == id);
        if (!existe)
        {
            return NotFound();
        }
        context.Remove(new Autor() { codigo = id });
        await context.SaveChangesAsync();
        return Ok();
        }*/
        //cuando queremos cambiar el estado(Borrar)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> delete( int id)
        {
            var existe = await context.Autor.AnyAsync(x => x.codigoautor == id);
            if (!existe)
            {
                return NotFound();
            }
            var autor = await context.Autor.FirstOrDefaultAsync(x => x.codigoautor == id);
            autor.estado = false;
            context.Update(autor);
            await context.SaveChangesAsync();
            return BadRequest("Se cambio estado correctamente");
        }
    }
}