using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;

namespace ExerciciosDesignPatterns.Estados
{
    class Positivo : EstadoConta
    {
        public void DepositaValor(ContaBancaria conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void SacaValor(ContaBancaria conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.Estado = new Negativo();
        }

        public void ConverteParaPositivo(ContaBancaria conta)
        {
            throw new Exception("A conta já está no estado positivo.");
        }

        public void ConverteParaNegativo(ContaBancaria conta)
        {
            conta.Estado = new Negativo();
        }


    }
}
