using System;
using System.Collections.Generic;

namespace Calculadora
{
    public class Calculadora
    {
        private delegate double MetodoOperacao(double num1, double num2);
        private List<Calculo> historico = new List<Calculo>();
        public Calculo Calcular(string num1, string num2, string codOp)
        {
            double numb1;
            double numb2;

            if (!Double.TryParse(num1, out numb1) || Double.TryParse(num2, out numb2))
                return null;

            if (!Enum.TryParse(codOp, out TipoOperacao operador))
                return null;

            var operacao = GetOperacao(operador);

            var resultado = Calcular(numb1, numb2, operacao);

            var calculo = new Calculo(numb1, numb2, resultado, operador);

            historico.Add(calculo);
            return calculo;
        }
        public string mostrarHistorico()
        {
            return "";
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

