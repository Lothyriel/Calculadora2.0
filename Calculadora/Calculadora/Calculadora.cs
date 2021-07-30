using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private delegate double MetodoOperacao(double num1, double num2);
        List<Calculo> historico = new List<Calculo>();
        public Calculadora()
        {
        }

        public Calculo Calcular(string num1, string num2, string codOp)
        {

        }
        private double Calcular(double num1, double num2, MetodoOperacao op)
        {
            return op(num1, num2);
        }
        private MetodoOperacao GetOperacao(TipoOperacao op)
        {
            double soma(double num1, double num2) { return num1 + num2; }
            double subtracao(double num1, double num2) { return num1 + num2; }
            double multiplicacao(double num1, double num2) { return num1 + num2; }
            double divisao(double num1, double num2) { return num1 + num2; }

            if (op == TipoOperacao.adicao)
                return soma;
            if (op == TipoOperacao.subtracao)
                return subtracao;
            if (op == TipoOperacao.multiplicacao)
                return multiplicacao;
            if (op == TipoOperacao.divisao)
                return divisao;
            else
                return null;
        }
    }
    public enum TipoOperacao
    {
        adicao, subtracao, multiplicacao, divisao
    }
}

