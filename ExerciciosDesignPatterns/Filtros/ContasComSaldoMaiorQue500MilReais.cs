using ExerciciosDesignPatterns.Interfaces.Decorator;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Filtros
{
    public class ContasComSaldoMaiorQue500MilReais : FiltroContasFraudulentas
    {
        public ContasComSaldoMaiorQue500MilReais()
        {
        }

        public ContasComSaldoMaiorQue500MilReais(FiltroContasFraudulentas proximoFiltro) : base(proximoFiltro)
        {
        }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            List<ContaBancaria> listaRetorno = new List<ContaBancaria>();
            foreach (ContaBancaria conta in contas)
            {
                if (conta.Saldo > 500000)
                    listaRetorno.Add(conta);
            }

            foreach (ContaBancaria conta in AplicaProximoFiltro(contas))
            {
                listaRetorno.Add(conta);
            }

            return listaRetorno;
        }
    }
}
