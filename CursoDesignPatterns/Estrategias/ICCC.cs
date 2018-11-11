using CursoDesignPatterns.Modelos;

namespace CursoDesignPatterns.Estrategias
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * DefinePorcentagemICCC(orcamento.Valor)) + DefineAditivoICCC(orcamento.Valor);
        }

        private double DefinePorcentagemICCC(double valorOrcamento)
        {
            if (valorOrcamento < 1000)
                return 0.05;

            if (valorOrcamento >= 1000 && valorOrcamento <= 3000)
                return 0.07;

            if (valorOrcamento > 3000)
                return 0.08;

            return 0;
        }

        private double DefineAditivoICCC(double valorOrcamento)
        {
            if (valorOrcamento > 3000)
                return 30;

            return 0;
        }
    }
}
