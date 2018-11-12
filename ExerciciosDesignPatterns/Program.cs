using ExerciciosDesignPatterns.Estrategias;
using ExerciciosDesignPatterns.Filtros;
using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Interfaces.Decorator;
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
            ExecutaFiltrosContasFraudulentas();
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

            ContaBancaria conta = new ContaBancaria("Olivia", DateTime.Now);
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

            ContaBancaria conta = new ContaBancaria("Olivia", DateTime.Now);
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
            ContaBancaria conta1 = new ContaBancaria("Olivia", DateTime.Now);
            conta1.Deposita(1000000);
            contas.Add(conta1);
            ContaBancaria conta2 = new ContaBancaria("Gertrudes", DateTime.Now);
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

        /// <summary>
        /// Conceito de Design Patterns estudado: Decorator
        /// </summary>
        public static void ExecutaFiltrosContasFraudulentas()
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();
            ContaBancaria conta1 = new ContaBancaria("Olivia", new DateTime(2018, 10, 12));
            conta1.Deposita(99);
            contas.Add(conta1);
            ContaBancaria conta2 = new ContaBancaria("Gertrudes", new DateTime(2018, 9, 12));
            conta2.Deposita(500001);
            contas.Add(conta2);
            ContaBancaria conta3 = new ContaBancaria("Genoveva", DateTime.Now);
            conta3.Deposita(1000);
            contas.Add(conta3);
            ContaBancaria conta4 = new ContaBancaria("Teodoro", new DateTime(2018, 8, 12));
            conta4.Deposita(1000);
            contas.Add(conta4);

            FiltroContasFraudulentas filtros = new ContasAbertasNoMesCorrente(new ContasComSaldoMaiorQue500MilReais(new ContasComSaldoMenorQue100Reais()));
            List<ContaBancaria> contasFraudulentas = filtros.Filtra(contas).ToList();
            foreach (ContaBancaria conta in contasFraudulentas)
            {
                Console.WriteLine("Agencia: " + conta.Agencia + " | Conta: " + conta.NroConta + " | Titular: " + conta.NomeTitular);
            }
        }
    }
}
