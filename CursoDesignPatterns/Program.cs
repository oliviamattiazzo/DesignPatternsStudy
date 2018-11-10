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
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculadora = new CalculadorDeImpostos();
            calculadora.RealizaCalculo(orcamento, iss);

            Console.ReadKey();
        }
    }
}
