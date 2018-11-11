using CursoDesignPatterns.Modelos;

namespace CursoDesignPatterns.Estrategias
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
