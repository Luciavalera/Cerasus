using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Valera.Lucia.Cerasus.API.Models;

namespace Valera.Lucia.Cerasus.API.DataBase
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options)
        {

        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Comida> Comidas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Suscriptor> Suscriptores { get; set; }
        public DbSet<Filosofia> Filosofias { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Boda> Bodas { get; set; }
        public DbSet<Comunion> Comuniones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Corporativo> Corporativos { get; set; }

    }
}
