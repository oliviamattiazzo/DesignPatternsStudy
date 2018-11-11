using ExerciciosDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Estrategias
{
    public class Arrojado : TipoInvestimento
    {
        public double Investe(double valorInvestido)
        {
            return valorInvestido * DefinePorcentagemInvestimentoArrojado();
        }

        private double DefinePorcentagemInvestimentoArrojado()
        {
            int chute = new Random().Next(10);
            if (chute >= 0 && chute <= 1)
                return 0.5;
            else if (chute >= 2 && chute <= 4)
                return 3;

            return 0.6;
        }
    }
}
