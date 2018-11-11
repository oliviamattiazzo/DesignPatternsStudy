using ExerciciosDesignPatterns.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDesignPatterns.Interfaces
{
    public interface RetornoRequisicao
    {
        string MontaRetorno(Formato formato, ContaBancaria conta);
        RetornoRequisicao Proximo { get; set; }
    }
}
