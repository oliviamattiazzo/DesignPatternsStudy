﻿using CursoDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Estrategias.TiposInvestimento
{
    public class Moderado : TipoInvestimento
    {
        public double Investe(double valorInvestido)
        {
            return valorInvestido * DefinePorcentagemInvestimentoArrojado();
        }

        private double DefinePorcentagemInvestimentoArrojado()
        {
            bool escolhido = new Random().Next(2) == 0;

            return escolhido ? 0.025 : 0.007;
        }
    }
}
