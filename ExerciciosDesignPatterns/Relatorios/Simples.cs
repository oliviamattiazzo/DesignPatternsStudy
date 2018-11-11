using ExerciciosDesignPatterns.MetodoTemplate;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Relatorios
{
    public class Simples : TemplateDeRelatorio
    {
        public override string Cabecalho()
        {
            return "Banco da Olivia S/A";
        }

        public override string Corpo(List<ContaBancaria> contas)
        {
            string retorno = string.Empty;

            foreach(ContaBancaria conta in contas)
            {
                retorno = retorno + "Nome do titular: " + conta.NomeTitular + " | Saldo disponível: R$" + conta.Saldo + "\n";
            }

            return retorno;
        }

        public override string Rodape()
        {
            return "Telefone: +55 (14) 1234-5678";
        }
    }
}
