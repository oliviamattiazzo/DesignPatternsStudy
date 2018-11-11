using ExerciciosDesignPatterns.MetodoTemplate;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Relatorios
{
    public class Complexo : TemplateDeRelatorio
    {
        public override string Cabecalho()
        {
            return "Banco da Olivia S/A - Rua do Limoeiro, 24-24 - Telefone: +55 (14) 1234-5678";
        }

        public override string Corpo(List<ContaBancaria> contas)
        {
            string retorno = string.Empty;

            foreach (ContaBancaria conta in contas)
            {
                retorno = retorno + "Nome do titular: " + conta.NomeTitular + "\n" +
                                    "Agência: " + conta.Agencia + " | Nro. da Conta: " + conta.NroConta + "\n" +
                                    "Saldo disponível: R$" + conta.Saldo + "\n\n";
            }

            return retorno;
        }

        public override string Rodape()
        {
            return "Email: oli.pmatt@gmail.com | Data: " + DateTime.Now;
        }
    }
}
