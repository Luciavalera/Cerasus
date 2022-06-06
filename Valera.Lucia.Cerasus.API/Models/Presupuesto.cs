using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valera.Lucia.Cerasus.API.Models
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public IEnumerable<PresupuestoLinea> Lineas { get; set; }
        public int? Total { get { return Lineas?.Sum(linea => linea.TotalLinea); } }
        
        //linea => linea.TotalLinea
        //public int? DevolverTotalLinea(PresupuestoLinea linea)
        //{
        //    return linea.TotalLinea;
        //}
    }
}
