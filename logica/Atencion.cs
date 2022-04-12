using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Atencion
    {
        public int DNICorrespondiente { get; set; }
        public Cobertura coberturaCorrespondiente { get; set; }
        public string TipoCorrespondiente { get; set; }
        public Enfermedad EnfermedadAtendida { get; set; }
        public Persona PacienteAtendido { get; set; }
    }
}
