using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Valera.Lucia.Cerasus.API.DataBase;
using Valera.Lucia.Cerasus.API.Models;

namespace Valera.Lucia.Cerasus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilosofiaController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public FilosofiaController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/Filosofia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filosofia>>> GetFilosofias()
        {
            return await _context.Filosofias.ToListAsync();
        }

        // GET: api/Filosofia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Filosofia>> GetFilosofia(int id)
        {
            var filosofia = await _context.Filosofias.FindAsync(id);

            if (filosofia == null)
            {
                return NotFound();
            }

            return filosofia;
        }

        // PUT: api/Filosofia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilosofia(int id, Filosofia filosofia)
        {
            if (id != filosofia.Id)
            {
                return BadRequest();
            }

            _context.Entry(filosofia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilosofiaExists(id))
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

        // POST: api/Filosofia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Filosofia>> PostFilosofia(Filosofia filosofia)
        {
            _context.Filosofias.Add(filosofia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilosofia", new { id = filosofia.Id }, filosofia);
        }

        // DELETE: api/Filosofia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilosofia(int id)
        {
            var filosofia = await _context.Filosofias.FindAsync(id);
            if (filosofia == null)
            {
                return NotFound();
            }

            _context.Filosofias.Remove(filosofia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilosofiaExists(int id)
        {
            return _context.Filosofias.Any(e => e.Id == id);
        }
    }
}
