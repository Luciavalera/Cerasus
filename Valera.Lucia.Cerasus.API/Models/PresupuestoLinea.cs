using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class PresupuestoLinea
    {
        public int Id { get; set; }
        public Presupuesto Presupuesto { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public int? TotalLinea { get { return Producto?.Precio * Cantidad; } }
    }
}
