using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Maxima:Cobertura
    {
        public override decimal CalcularCostoCobertura()
        {
            decimal CostoCobertura = Enfermedades.Sum(x => x.Costo);
            return CostoCobertura;

        }
        public override bool EsValidoParaAtenciones(string tipo)
        {
            foreach (var item in Enfermedades)
            {
                if (item.Tipo == tipo)
                    return true;
            }
            return false;
        }
    }
}
