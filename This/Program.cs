using System;
using System.Globalization;
namespace Aula47
// Usando Construtor na Classe Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Console.Write("Quantidade no estoque: ");
            // int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Produto p = new Produto(nome,preco);
            // Produto p2 = new Produto();
            
            
            
            // Uma Forma de Usar instanciar a classe Produto que funciona com ou sem um construtor 
            // Onde vc pode Instanciar a classe Produtos ja passando os valores dos dados 
            // Ex: 
            // ====================
            Produto p3 = new Produto { 
                Nome= "Tv", 
                Preco=500.00 , 
                Quantidade=20
            };
            // ====================
            // OBS : So se da para fazer essa instanciação caso a classe tenha uma sobrecarga ou nao tenha um construtor definido 
            
            
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
