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
    public class ComunionController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public ComunionController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/Comunion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comunion>>> GetComuniones()
        {
            return await _context.Comuniones.ToListAsync();
        }

        // GET: api/Comunion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comunion>> GetComunion(int id)
        {
            var comunion = await _context.Comuniones.FindAsync(id);

            if (comunion == null)
            {
                return NotFound();
            }

            return comunion;
        }

        // PUT: api/Comunion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComunion(int id, Comunion comunion)
        {
            if (id != comunion.Id)
            {
                return BadRequest();
            }

            _context.Entry(comunion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComunionExists(id))
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

        // POST: api/Comunion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comunion>> PostComunion(Comunion comunion)
        {
            _context.Comuniones.Add(comunion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComunion", new { id = comunion.Id }, comunion);
        }

        // DELETE: api/Comunion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComunion(int id)
        {
            var comunion = await _context.Comuniones.FindAsync(id);
            if (comunion == null)
            {
                return NotFound();
            }

            _context.Comuniones.Remove(comunion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComunionExists(int id)
        {
            return _context.Comuniones.Any(e => e.Id == id);
        }
    }
}
