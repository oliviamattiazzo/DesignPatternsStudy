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
        public static void ExecutaCalculadorDeImpostos()
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
        public static void ExecutaCalculadorDeDescontos()
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

        /// <summary>
        /// Conceito de Design Patterns estudado: Template Method
        /// </summary>
        public static void ExecutaCalculadorDeImpostosTemplateMethod()
        {
            Orcamento orcamentoMenorQue500 = new Orcamento(499);
            Orcamento orcamentoMaiorQue500 = new Orcamento(501);

            var impostoICPP = new ICPP();
            var impostoIKCV = new IKCV();

            Console.WriteLine("ICPP e Orcamento menor que R$500");
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamentoMenorQue500, impostoICPP);

            Console.WriteLine("ICPP e Orcamento maior que R$500");
            calculador.RealizaCalculo(orcamentoMaiorQue500, impostoICPP);

            Console.WriteLine("ICKV, Orcamento maior que R$500 e sem item caro (mais de R$100)");
            calculador.RealizaCalculo(orcamentoMaiorQue500, impostoIKCV);

            Console.WriteLine("ICKV, Orcamento maior que R$500 e com item caro (mais de R$100)");
            orcamentoMaiorQue500.Itens.Add(new Item("Item caro", 101));
            calculador.RealizaCalculo(orcamentoMaiorQue500, impostoIKCV);
        }

        /// <summary>
        /// Conceito de Design Patterns estudado: Decorator
        /// </summary>
        public static void ExecutaCalculadorDeImpostosDecorator()
        {
            Imposto iss = new ImpostoMuitoAlto(new ICMS());
            Orcamento orcamento = new Orcamento(500);

            double valor = iss.Calcula(orcamento);
            Console.WriteLine("Valor dos impostos: " + valor);
        }

        /// <summary>
        /// Conceito de Design Patterns estudado: State
        /// </summary>
        public static void ExecutaCalculadoraDeDescontosState()
        {
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();
        }
    }
}
