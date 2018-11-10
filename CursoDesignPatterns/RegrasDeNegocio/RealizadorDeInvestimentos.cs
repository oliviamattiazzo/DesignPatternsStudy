using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.RegrasDeNegocio
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria contaBancaria, TipoInvestimento tpInvestimento)
        {
            double rendimentoInvestimento = tpInvestimento.Investe(contaBancaria.Saldo);
            Console.WriteLine("Rendimento do Investimento: " + rendimentoInvestimento);

            contaBancaria.Deposita(rendimentoInvestimento * 0.75);
        }
    }
}
