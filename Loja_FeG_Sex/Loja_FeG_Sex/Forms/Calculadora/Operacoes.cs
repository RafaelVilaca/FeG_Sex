using System;

namespace Loja_FeG_Sex.Forms.Calculadora
{
    public class Operacoes
    {
        double resultado = 0;

        public string Soma(double n1, double n2)
        {
            resultado = n1 + n2;
            return Convert.ToString(resultado);
        }

        public string Subtracao(double n1, double n2)
        {
            resultado = n1 - n2;
            return Convert.ToString(resultado);
        }

        public string Multi(double n1, double n2)
        {            
            resultado = n1 * n2;
            return Convert.ToString(resultado);
        }

        public string Divisao(double n1, double n2)
        {
            resultado = n1 / n2;
            return Convert.ToString(resultado);
        }
    }
}
