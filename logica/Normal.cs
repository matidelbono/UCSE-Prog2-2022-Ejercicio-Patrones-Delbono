using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Normal:Cobertura
    {
        public override decimal CalcularCostoCobertura()
        {
            decimal promedio = Enfermedades.Average(x => x.Costo);
            decimal CostoCobertura = CostoBase + promedio;
            return CostoCobertura;
        }
        public override bool EsValidoParaAtenciones(string Nombre)
        {
            foreach (var item in Enfermedades)
            {
                if (item.Nombre == Nombre)
                    return true;
            }
            return false;
        }
}
}
