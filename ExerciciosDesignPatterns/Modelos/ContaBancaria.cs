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
        public string NomeTitular { get; private set; }
        public string Agencia { get; private set; } = new Random().Next(1000, 9999).ToString();
        public string NroConta { get; private set; } = new Random().Next(10000, 99999).ToString();
        public DateTime DataAbertura { get; private set; }

        public ContaBancaria(string nomeTitular, DateTime dataAbertura)
        {
            NomeTitular = nomeTitular;
            DataAbertura = dataAbertura;
        }

        public void Deposita(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine("Novo saldo da conta: " + Saldo);
        }
    }
}
