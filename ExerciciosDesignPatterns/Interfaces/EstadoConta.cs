using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosDesignPatterns.Modelos;

namespace ExerciciosDesignPatterns.Interfaces
{
    public interface EstadoConta
    {
        void DepositaValor(ContaBancaria conta, double valor);

        void SacaValor(ContaBancaria conta, double valor);

        void ConverteParaPositivo(ContaBancaria conta);

        void ConverteParaNegativo(ContaBancaria conta);
    }
}
