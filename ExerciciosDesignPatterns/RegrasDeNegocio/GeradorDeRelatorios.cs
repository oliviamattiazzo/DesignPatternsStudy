using ExerciciosDesignPatterns.Interfaces;
using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.RegrasDeNegocio
{
    public class GeradorDeRelatorios
    {
        public void GeraRelatorios(List<ContaBancaria> contas, Relatorio tipoRelatorio)
        {
            tipoRelatorio.Monta(contas);
        }
    }
}
