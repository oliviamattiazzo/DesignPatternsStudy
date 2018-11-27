using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;

namespace ExerciciosDesignPatterns.Estados
{
    class Negativo : EstadoConta
    {
        public void DepositaValor(ContaBancaria conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new Positivo();
        }

        public void SacaValor(ContaBancaria conta, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }

        public void ConverteParaPositivo(ContaBancaria conta)
        {
            conta.Estado = new Positivo();
        }

        public void ConverteParaNegativo(ContaBancaria conta)
        {
            throw new Exception("A conta já está no estado negativo.");
        }
    }
}
