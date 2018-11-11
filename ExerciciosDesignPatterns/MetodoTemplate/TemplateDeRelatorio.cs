using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.MetodoTemplate
{
    public abstract class TemplateDeRelatorio : Relatorio
    {
        public abstract string Cabecalho();
        public abstract string Corpo(List<ContaBancaria> contas);
        public abstract string Rodape();

        public virtual void Monta(List<ContaBancaria> contas)
        {
            Console.WriteLine("***** Relatório *****");
            Console.WriteLine(Cabecalho());
            Console.WriteLine("*********************");
            Console.WriteLine(Corpo(contas));
            Console.WriteLine("*********************");
            Console.WriteLine(Rodape());
        }
    }
}
