using api_autores.Entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_autores.Controllers
{
    [ApiController]
    [Route("api-autores/libro")]
    public class LibroController : ControllerBase
    {
        private readonly ApplicationDBContext context;

        public LibroController(ApplicationDBContext context)
        {
            this.context = context;
        }
        //cuando queremos obtener informacion
        [HttpGet]
        public async Task<ActionResult<List<Libro>>> findAll()
        {
            return await context.Libro.Include(x=>x.autor).ToListAsync();
        }
        //cuando queremos obtener solo los habilitados
        [HttpGet("custom")]
        public async Task<ActionResult<List<Libro>>> findAllCustom()
        {
            return await context.Libro.Include(x => x.autor).Where(x => x.estado == true).ToListAsync();
        }
        //cuando queremos guardar informacion
        [HttpPost]
        public async Task<ActionResult> add(Libro l)
        {
            // Verificar si autor existe
            var autorexiste = await context.Autor.AnyAsync(x=>x.codigoautor == l.codigoautor);
            if (!autorexiste)
            {
                return BadRequest($"No existe el autor con codigo:{l.codigoautor}");
            }
            context.Add(l);
            await context.SaveChangesAsync();
            return BadRequest("Se Guardo correctamente");
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Libro>> findById(int id)
        {
            var libro = await context.Libro
                .FirstOrDefaultAsync(x => x.codigolibro == id);
            return libro;
        }
        //cuando queremos actualizar informacion
        [HttpPut("{id:int}")]
        public async Task<ActionResult> update(Libro l, int id)
        {
            if (l.codigolibro != id)
            {
                return BadRequest("No se encontro el codigo correspondiente");
            }
            context.Update(l);
            await context.SaveChangesAsync();
            return BadRequest("Se actualizo correctamente");
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> delete(int id)
        {
            var existe = await context.Libro.AnyAsync(x => x.codigolibro == id);
            if (!existe)
            {
                return NotFound();
            }
            var libro = await context.Libro.FirstOrDefaultAsync(x => x.codigolibro == id);
            libro.estado = false;
            context.Update(libro);
            await context.SaveChangesAsync();
            return BadRequest("Se cambio estado correctamente");
        }
    }
}
