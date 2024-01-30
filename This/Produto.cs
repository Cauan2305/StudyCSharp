using System.Globalization;
namespace Aula47
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        
        public Produto()
        {
            Quantidade=10;
        }
        // Usando This Estou Reaproveitando do 1 Construtor onde eu seto a Quantidade ==10 
        public Produto(string nome, double preco) :this()
        {
            Nome=nome;
            Preco=preco;
        }
        
        // Usando This Estou Reaproveitando do 2 Construtor onde eu seto a nome , preco  
        public Produto(string nome, double preco , int quantidade) : this(nome,preco)
        {
            Quantidade=quantidade;
        }

        // Outro Exemplo usando o This 
        // public Produto (string Nome , double Preco)
        // {
        //     // Aqui estou usando os parametros igual ao nome do construtor 
        //     // para que o compilador possa diferenciar preciso usar o this
        //     this.Nome=Nome;
        //     this.Preco=Preco;
        // }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}