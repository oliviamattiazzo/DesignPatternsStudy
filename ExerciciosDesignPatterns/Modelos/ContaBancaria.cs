using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Modelos
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine("Novo saldo da conta: " + Saldo);
        }
    }
}
