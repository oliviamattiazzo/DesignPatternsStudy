using ExerciciosDesignPatterns.Estrategias;
using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using ExerciciosDesignPatterns.RegrasDeNegocio;
using ExerciciosDesignPatterns.Relatorios;
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
            ExecutaGeracaoRelatorios();
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

        /// <summary>
        /// Conceito de Design Patterns estudado: Template Method
        /// </summary>
        public static void ExecutaGeracaoRelatorios()
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();
            ContaBancaria conta1 = new ContaBancaria("Olivia");
            conta1.Deposita(1000000);
            contas.Add(conta1);
            ContaBancaria conta2 = new ContaBancaria("Gertrudes");
            conta2.Deposita(1000);
            contas.Add(conta2);

            Console.WriteLine("");

            var relatorioSimples = new Simples();
            var relatorioComplexo = new Complexo();

            Console.WriteLine("****** RELATÓRIO SIMPLES ******");
            GeradorDeRelatorios gerador = new GeradorDeRelatorios();
            gerador.GeraRelatorios(contas, relatorioSimples);

            Console.WriteLine("\n");

            Console.WriteLine("****** RELATÓRIO COMPLEXO ******");
            gerador.GeraRelatorios(contas, relatorioComplexo);
        }
    }
}
