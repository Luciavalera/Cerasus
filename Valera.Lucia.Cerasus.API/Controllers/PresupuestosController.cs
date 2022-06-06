using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valera.Lucia.Cerasus.API.DataBase;
using Valera.Lucia.Cerasus.API.Models;

namespace Valera.Lucia.Cerasus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresupuestosController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public PresupuestosController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: api/Presupuestos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Presupuesto>>> GetPresupuestos()
        {
            return await _context.Presupuestos.ToListAsync();
        }

        // GET: api/Presupuestos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Presupuesto>> GetPresupuesto(int id)
        {
            var presupuesto = await _context.Presupuestos.FindAsync(id);

            if (presupuesto == null)
            {
                return NotFound();
            }

            return presupuesto;
        }

        // POST: api/Presupuestos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Presupuesto>> PostPresupuesto(Presupuesto presupuesto)
        {
            var precioComida = _context.Comidas.Where(x => x.Nombre == presupuesto.Formulario.Comida).FirstOrDefault().Precio;
            var precioLugar = _context.Lugares.Where(x => x.Nombre == presupuesto.Formulario.Lugar).FirstOrDefault().Precio;
            presupuesto.Total = precioComida * presupuesto.Formulario.Invitados + precioLugar;
            _context.Presupuestos.Add(presupuesto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPresupuesto", new { id = presupuesto.Id }, presupuesto);
        }
    }
}
