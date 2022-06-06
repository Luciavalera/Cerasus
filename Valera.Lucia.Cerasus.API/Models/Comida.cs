using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class Comida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }
}
