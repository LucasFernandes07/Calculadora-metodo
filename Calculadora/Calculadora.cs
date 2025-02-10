
using Valor;

namespace Calculadora

{
  
    class Operacoes
    {
        public static void RealizarAdicao( 
            decimal valor1, 
            decimal valor2
        )
         
        {
          Console.WriteLine($"\nA soma dos valores {valor1} e {valor2} é igual a: {valor1 + valor2}");
        }
        
        public static void RealizarSubtracao( 
            decimal valor1, 
            decimal valor2
        )
        {
          Console.WriteLine($"\nA subtração dos valores {valor1} e {valor2} é igual a: {valor1 - valor2} ");
        }
         public static void RealizarMultiplicacao( 
            decimal valor1, 
            decimal valor2
        )
        {
          Console.WriteLine($"\nA multiplicação dos valores {valor1} e {valor2} é igual a: {valor1 * valor2}");
        }
         public static void RealizarDivisao( 
            decimal valor1, 
            decimal valor2
        )
        {
          Console.WriteLine($"\nA divisão dos valores {valor1} e {valor2} é igual a: {valor1 / valor2}");
        }
    }

}