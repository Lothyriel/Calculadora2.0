using System;

namespace Calculadora
{
    public class Calculo
    {
        private double NumeroUm;
        private double NumeroDois;
        private TipoOperacao operacao;
        private double Resultado;
        Calculo(double NumeroUm, double NumeroDois, double resultado, TipoOperacao operacao)
        {
            this.operacao = operacao;
            this.NumeroUm = NumeroUm;
            this.NumeroDois = NumeroDois;
            this.Resultado = resultado;
        }

        public override string ToString()
        {
            return $"{NumeroUm} {mostrarOperacao()} {NumeroDois} = {Resultado}"; 


        }

        private string mostrarOperacao()
        {
            if (operacao == TipoOperacao.adicao)
                return "+";
            if (operacao == TipoOperacao.subtracao)
                return "-";
            if (operacao == TipoOperacao.multiplicacao)
                return "*";
            if (operacao == TipoOperacao.divisao)
                return "/";
            else
                return null;

        }

    }

}