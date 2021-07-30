using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private delegate Calculo MetodoOperacao(double num1, double num2);
        List<Calculo> historico = new List<Calculo>();
        public Calculadora()
        {
        }

        public Calculo Calcular(string num1, string num2, string codOp)
        {
            return null;
        }
        private MetodoOperacao GetOperacao(TipoOperacao op)
        {
            throw new NotImplementedException();
        }
        private Calculo Calcular(double num1, double num2, MetodoOperacao op)
        {
            return op(num1, num2);
        }



    }

    public enum TipoOperacao
    {
        adicao, subtracao, multiplicacao, divisao
    }


}
