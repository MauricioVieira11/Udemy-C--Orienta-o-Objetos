using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            
            Console.WriteLine("preço é: "+desconto);
        }
    }
}
