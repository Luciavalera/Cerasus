using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Valera.Lucia.Cerasus.API.Models;

namespace Valera.Lucia.Cerasus.API.DataBase
{
    public class EcommerceContextSeed
    {
        public static async Task SeedAsync(EcommerceContext context)
        {
            if (!context.Colaboradores.Any())
            {
                var data = File.ReadAllText("./SeedData/colaborador.json");
                var items = JsonSerializer.Deserialize<List<Colaborador>>(data);
                foreach (var item in items)
                {
                    context.Colaboradores.Add(item);
                }
                await context.SaveChangesAsync();
            }
            if (!context.Comidas.Any())
            {
                var data = File.ReadAllText("./SeedData/comidas.json");
                var items = JsonSerializer.Deserialize<List<Comida>>(data);
                foreach (var item in items)
                {
                    context.Comidas.Add(item);
                }
                await context.SaveChangesAsync();
            }
            if (!context.Contactos.Any())
            {
                var data = File.ReadAllText("./SeedData/contactos.json");
                var items = JsonSerializer.Deserialize<List<Contacto>>(data);
                foreach (var item in items)
                {
                    context.Contactos.Add(item);
                }
                await context.SaveChangesAsync();
            }
            if (!context.Equipos.Any())
            {
                var data = File.ReadAllText("./SeedData/equipos.json");
                var items = JsonSerializer.Deserialize<List<Equipo>>(data);
                foreach (var item in items)
                {
                    context.Equipos.Add(item);
                }
                await context.SaveChangesAsync();
            }
            if (!context.Infos.Any())
            {
                var data = File.ReadAllText("./SeedData/infos.json");
                var items = JsonSerializer.Deserialize<List<Info>>(data);
                foreach (var item in items)
                {
                    context.Infos.Add(item);
                }
                await context.SaveChangesAsync();
            }
            if (!context.Lugares.Any())
            {
                var data = File.ReadAllText("./SeedData/lugares.json");
                var items = JsonSerializer.Deserialize<List<Lugar>>(data);
                foreach (var item in items)
                {
                    context.Lugares.Add(item);
                }
                await context.SaveChangesAsync();
            }
        }
    }
}
