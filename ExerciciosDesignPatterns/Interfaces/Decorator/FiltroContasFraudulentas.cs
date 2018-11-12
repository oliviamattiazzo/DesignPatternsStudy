using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Interfaces.Decorator
{
    public abstract class FiltroContasFraudulentas
    {
        public FiltroContasFraudulentas ProximoFiltro { get; set; }

        public FiltroContasFraudulentas() { }

        public FiltroContasFraudulentas(FiltroContasFraudulentas proximoFiltro) { ProximoFiltro = proximoFiltro; }

        public abstract IList<ContaBancaria> Filtra(IList<ContaBancaria> contas);

        protected IList<ContaBancaria> AplicaProximoFiltro(IList<ContaBancaria> contas)
        {
            if (ProximoFiltro != null) return ProximoFiltro.Filtra(contas);
            else return new List<ContaBancaria>();
        }
    }
}
