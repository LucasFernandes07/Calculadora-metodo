namespace Valor
{
    class Obtervalor
    {
        public static decimal ObterValores ()
        {
            
            return_valor:
            Console.Write("\nInsira um valor: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal  valor))
            {
                Console.WriteLine("Insira um valor válido.");
                goto return_valor;
            }
            else
            {
                 return valor;
            }
           
        }
    }
}