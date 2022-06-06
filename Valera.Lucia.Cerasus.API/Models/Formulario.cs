using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class Formulario
    {
        public int Id { get; set; }
        public string NombreApellidos { get; set; }
        public string Evento { get; set; }
        public int Invitados { get; set; }
        public string Comida { get; set; }
        public string Lugar { get; set; }
        public string Mensaje { get; set; }
    }
}
