using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Valera.Lucia.Cerasus.API.Enums;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public TipoEvento NombreEvento { get; set; }
        public int Invitados { get; set; }
        public int Precio { get {
                return Comida.Nombre == TipoComida.Menu.ToString() ? Comida.Precio * Invitados + Lugar.Precio : Comida.Precio * Invitados + Lugar.Precio;
            } } 
        public Lugar Lugar { get; set; }
        public Comida Comida { get; set; }
        public Usuario Usuario { get; set; }
    }

}
