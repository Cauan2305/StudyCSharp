using System;
using System.Globalization;
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv",500.00,10);
            Console.WriteLine(p.GetNome());
            p.SetNome("Tv 4k");
            Console.WriteLine(p.GetNome());
            Console.WriteLine($"Preco : {p.GetPreco()}");
            Console.WriteLine($"Quantidade : {p.GetQuantidade()}");
        
        }
    }
}
