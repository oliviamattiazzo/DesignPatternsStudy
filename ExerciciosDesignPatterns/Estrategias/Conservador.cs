using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosDesignPatterns.Interfaces;

namespace ExerciciosDesignPatterns.Estrategias
{
    public class Conservador : TipoInvestimento
    {
        public double Investe(double valorInvestido)
        {
            return valorInvestido * 0.008;
        }
    }
}
