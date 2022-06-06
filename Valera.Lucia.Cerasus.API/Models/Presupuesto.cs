using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public Formulario Formulario { get; set; }
    }
}
