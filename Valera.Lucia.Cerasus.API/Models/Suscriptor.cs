using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class Suscriptor
    {
        public int Id { get; set; }

        [EmailAddress]
        public string Correo { get; set; }
    }
}
