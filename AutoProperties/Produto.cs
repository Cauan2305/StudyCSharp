using System.Globalization;
namespace Properties
{
    class Produto
    {
        // O Nome Tem Uma Logica nele entao nao daria para usar uma auto propertie
        private string _nome;
        // Propertie
        public string Nome { 
            get { 
                return _nome;
            }

            set {
                if (value != null && value.Length >1)
                {
                    _nome=value;
                }
            }
        }
        // Convenção quando for private vai ser _+letra minuscula
        // Add AutoProperties 
        // prop + TAB == Cria automatico
        public  double Preco {get ; private set;}
        
        public int Quantidade {get; private set;}
        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome=nome;
            Preco=preco;
            Quantidade=quantidade;

        }
        
        // Metods
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}