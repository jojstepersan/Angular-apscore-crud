using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pruebaAngular.Model;
using pruebaAngular.Repository;

namespace pruebaAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly LibreriaDBContext _context;
        private readonly IGeneroService _generoService;
        public GeneroController(LibreriaDBContext context,IGeneroService generoService)
        {
            _context = context;
            _generoService = generoService;
        }

        // GET: api/Genero
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> Getgenero()
        {
            return await _context.genero.ToListAsync();
        }

        // GET: api/Genero/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genero>> GetGenero(int id)
        {
            var genero = await _context.genero.FindAsync(id);

            if (genero == null)
            {
                return NotFound();
            }

            return genero;
        }

        // PUT: api/Genero/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenero(int id, Genero genero)
        {
            if (id != genero.idGenero)
            {
                return BadRequest();
            }

            _context.Entry(genero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Genero
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Genero>> PostGenero(Genero genero)
        {
            _generoService.Insert(genero);                        
            return CreatedAtAction("GetGenero", new { id = genero.idGenero }, genero);
        }

        // DELETE: api/Genero/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Genero>> DeleteGenero(int id)
        {
            var genero = await _context.genero.FindAsync(id);
            if (genero == null)
            {
                return NotFound();
            }

            _context.genero.Remove(genero);
            await _context.SaveChangesAsync();

            return genero;
        }

        private bool GeneroExists(int id)
        {
            return _context.genero.Any(e => e.idGenero == id);
        }
    }
}
