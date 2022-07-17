using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta
{
    public class IngresosyEgresos
    {

        public int Id { get; set; }
        public string Concept { get; set; }
        public string Category { get; set; }
        public string Quality { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
