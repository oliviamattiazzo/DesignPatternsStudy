using System;
using ExerciciosDesignPatterns.Estados;
using ExerciciosDesignPatterns.Interfaces;

namespace ExerciciosDesignPatterns.Modelos
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public string NomeTitular { get; private set; }
        public string Agencia { get; private set; } = new Random().Next(1000, 9999).ToString();
        public string NroConta { get; private set; } = new Random().Next(10000, 99999).ToString();
        public DateTime DataAbertura { get; private set; }
        public EstadoConta Estado;

        public ContaBancaria(string nomeTitular, DateTime dataAbertura)
        {
            NomeTitular = nomeTitular;
            DataAbertura = dataAbertura;
            if (Saldo >= 0) Estado = new Positivo(); else Estado = new Negativo();
        }

        public void Deposita(double valor)
        {
            Estado.DepositaValor(this, valor);
            Console.WriteLine("Novo saldo da conta: " + Saldo);
        }

        public void Saca(double valor)
        {
            Estado.SacaValor(this, valor);
            Console.WriteLine("Novo saldo da conta: " + Saldo);
        }
    }
}
