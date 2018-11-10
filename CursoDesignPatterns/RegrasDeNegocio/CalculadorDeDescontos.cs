using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.RegrasDeNegocio
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return 0;
        }
    }
}
