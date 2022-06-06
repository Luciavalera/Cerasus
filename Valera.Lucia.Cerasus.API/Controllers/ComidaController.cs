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
    public class ComidaController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public ComidaController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/Comida
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comida>>> GetComidas()
        {
            return await _context.Comidas.ToListAsync();
        }

        // GET: api/Comida/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comida>> GetComida(int id)
        {
            var comida = await _context.Comidas.FindAsync(id);

            if (comida == null)
            {
                return NotFound();
            }

            return comida;
        }

        // PUT: api/Comida/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComida(int id, Comida comida)
        {
            if (id != comida.Id)
            {
                return BadRequest();
            }

            _context.Entry(comida).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComidaExists(id))
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

        // POST: api/Comida
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comida>> PostComida(Comida comida)
        {
            _context.Comidas.Add(comida);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComida", new { id = comida.Id }, comida);
        }

        // DELETE: api/Comida/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComida(int id)
        {
            var comida = await _context.Comidas.FindAsync(id);
            if (comida == null)
            {
                return NotFound();
            }

            _context.Comidas.Remove(comida);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComidaExists(int id)
        {
            return _context.Comidas.Any(e => e.Id == id);
        }
    }
}
