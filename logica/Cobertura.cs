using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
  public  abstract class Cobertura
    {
        public string Descripcion { get; set; }
        public string Empresa { get; set; }
        public int IntegrantesdelaFamilia { get; set; }
        public decimal CostoBase { get; set; }
        public List<Enfermedad> Enfermedades { get; set; }
        public abstract decimal CalcularCostoCobertura();
        public abstract bool EsValidoParaAtenciones(string tipo);
    }
}

