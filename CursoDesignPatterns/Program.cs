using CursoDesignPatterns.Estrategias;
using CursoDesignPatterns.Modelos;
using CursoDesignPatterns.RegrasDeNegocio;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        /// <summary>
        /// Conceito de Design Patterns estudado: Strategy
        /// </summary>
        public void ExecutaCalculadorDeImpostos()
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculadora = new CalculadorDeImpostos();
            calculadora.RealizaCalculo(orcamento, iss);
        }

        /// <summary>
        /// Conceito de Design Patterns estudado: Chain of Responsibility
        /// </summary>
        public void ExecutaCalculadorDeDescontos()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lapis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogao", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("Xbox", 250));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
