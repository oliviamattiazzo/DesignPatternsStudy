using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CadeiaDeResponsabilidade
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (VendaCasadaLapisCaneta(orcamento.Itens))
            {
                return orcamento.Valor * 0.05;
            }

            return Proximo.Desconta(orcamento);
        }

        private bool VendaCasadaLapisCaneta(IList<Item> itensOrcamento)
        {
            bool existeLapis = false;
            if (itensOrcamento.Any(a => a.Nome.Equals("Lapis")))
                existeLapis = true;

            bool existeCaneta = false;
            if (itensOrcamento.Any(a => a.Nome.Equals("Caneta")))
                existeCaneta = true;

            return existeLapis && existeCaneta;
        }
    }
}
