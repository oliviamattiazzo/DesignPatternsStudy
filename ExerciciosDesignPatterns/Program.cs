using ExerciciosDesignPatterns.Estrategias;
using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using ExerciciosDesignPatterns.RegrasDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutaProcessamentoRequisicao();
            Console.ReadKey();
        }

        /// <summary>
        /// Conceito de Design Patterns estudado: Strategy
        /// </summary>
        public static void ExecutaCalculadorInvestimentos()
        {
            TipoInvestimento arrojado = new Arrojado();
            TipoInvestimento conservador = new Conservador();
            TipoInvestimento moderado = new Moderado();

            ContaBancaria conta = new ContaBancaria("Olivia");
            conta.Deposita(500);

            RealizadorDeInvestimentos investir = new RealizadorDeInvestimentos();
            investir.RealizaInvestimento(conta, arrojado);
        }

        /// <summary>
        /// Conceito de Design Patterns estudado: Chain of Responsibility
        /// </summary>
        public static void ExecutaProcessamentoRequisicao()
        {
            ProcessamentoDeRequisicao processadorRequisicoes = new ProcessamentoDeRequisicao();

            ContaBancaria conta = new ContaBancaria("Olivia");
            conta.Deposita(1000);

            Requisicao requisicao = new Requisicao(Formato.XML);

            string retorno = processadorRequisicoes.FormataRetorno(requisicao, conta);
            Console.WriteLine(retorno);
        }
    }
}
