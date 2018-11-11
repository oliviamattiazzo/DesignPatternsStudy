using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.CadeiaDeResponsabilidade
{
    public class SemFormato : RetornoRequisicao
    {
        public RetornoRequisicao Proximo { get; set; }

        public string MontaRetorno(Formato formato, ContaBancaria conta)
        {
            return "Nenhum formato fornecido!";
        }
    }
}
