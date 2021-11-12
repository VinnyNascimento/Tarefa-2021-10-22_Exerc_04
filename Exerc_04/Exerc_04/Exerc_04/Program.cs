using System;

namespace Exerc_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra a Área de um Triângulo");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor da base de um triângulo: ");
            s.setNum1(double.Parse(Console.ReadLine()));

            Console.Write("Informe o valor da altura de um triângulo: ");
            s.setNum2(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("A base do triângulo {0} com a Altura do triângulo {1}, da uma área de: {2}", s.getNum1(), s.getNum2(), s.getResultado());
            #endregion
        }
    }
}