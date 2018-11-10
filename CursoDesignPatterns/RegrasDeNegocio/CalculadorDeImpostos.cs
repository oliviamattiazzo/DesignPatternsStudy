using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    //Classe que conterá a regra de negócio de cálculo de imposto
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double resultado = imposto.Calcula(orcamento);  
            Console.WriteLine(resultado);
        }
    }
}
