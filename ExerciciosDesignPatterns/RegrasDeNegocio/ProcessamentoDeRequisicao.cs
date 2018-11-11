using ExerciciosDesignPatterns.CadeiaDeResponsabilidade;
using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.RegrasDeNegocio
{
    public class ProcessamentoDeRequisicao
    {
        public string FormataRetorno(Requisicao requisicao, ContaBancaria conta)
        {
            RetornoRequisicao r1 = new Xml();
            RetornoRequisicao r2 = new Csv();
            RetornoRequisicao r3 = new Porcento();
            RetornoRequisicao r4 = new SemFormato();

            r1.Proximo = r2;
            r2.Proximo = r3;
            r3.Proximo = r4;

            return r1.MontaRetorno(requisicao.Formato, conta);
        }
    }
}
