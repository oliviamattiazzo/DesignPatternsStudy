using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.CadeiaDeResponsabilidade
{
    public class Xml : RetornoRequisicao
    {
        public RetornoRequisicao Proximo { get; set; }

        public string MontaRetorno(Formato formato, ContaBancaria conta)
        {
            if (formato.Equals(Formato.XML))
                return @"<?xml version=""1.0""?>" +
                        "<conta>" +
                        "<nome_titular>" + conta.NomeTitular + "</nome_titular>" +
                        "<saldo_conta>" + conta.Saldo + "</saldo_conta>" +
                        "</conta>";

            return Proximo.MontaRetorno(formato, conta);
        }
    }
}
