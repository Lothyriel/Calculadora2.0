using System;

namespace Calculadora
{
    public class Calculo
    {
        private double NumeroUm;
        private double NumeroDois;
        private TipoOperacao operacao;

        Calculo(double NumeroUm, double NumeroDois, TipoOperacao operacao)
        {
            this.operacao = operacao;
            this.NumeroUm = NumeroUm;
            this.NumeroDois = NumeroDois;



        }

        public override string ToString()
        {
            return RealisarCalculo();
        }

        private string RealisarCalculo()
        {
            return


        }

        private class Operacao
        {
            TipoOperacao Operacao;

            MetodoOperacao

         

        }

    }

}