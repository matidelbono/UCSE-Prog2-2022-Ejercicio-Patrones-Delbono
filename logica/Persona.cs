using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Persona
    {
        public string NombreApellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
        public Decimal IngresosNetos { get; set; }
    }
}

