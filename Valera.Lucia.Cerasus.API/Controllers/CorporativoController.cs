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
    public class CorporativoController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public CorporativoController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/Corporativo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Corporativo>>> GetCorporativos()
        {
            return await _context.Corporativos.ToListAsync();
        }

        // GET: api/Corporativo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Corporativo>> GetCorporativo(int id)
        {
            var corporativo = await _context.Corporativos.FindAsync(id);

            if (corporativo == null)
            {
                return NotFound();
            }

            return corporativo;
        }

        // PUT: api/Corporativo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCorporativo(int id, Corporativo corporativo)
        {
            if (id != corporativo.Id)
            {
                return BadRequest();
            }

            _context.Entry(corporativo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CorporativoExists(id))
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

        // POST: api/Corporativo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Corporativo>> PostCorporativo(Corporativo corporativo)
        {
            _context.Corporativos.Add(corporativo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCorporativo", new { id = corporativo.Id }, corporativo);
        }

        // DELETE: api/Corporativo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCorporativo(int id)
        {
            var corporativo = await _context.Corporativos.FindAsync(id);
            if (corporativo == null)
            {
                return NotFound();
            }

            _context.Corporativos.Remove(corporativo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CorporativoExists(int id)
        {
            return _context.Corporativos.Any(e => e.Id == id);
        }
    }
}
