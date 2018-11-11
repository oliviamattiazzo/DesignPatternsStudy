﻿using CursoDesignPatterns.MetodoTemplate;
using CursoDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Estrategias
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ExistemDoisItensComMesmoNome(orcamento.Itens);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * ((1 * orcamento.Itens.Count) / 100);
        }

        private bool ExistemDoisItensComMesmoNome(IList<Item> itens)
        {
            return itens.GroupBy(item => item.Nome).Count() < itens.Count;
        }
    }
}