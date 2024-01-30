namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv",500.00,10);
            Console.WriteLine(p);
            p.Nome="Tv 4k";
            Console.WriteLine();
            
        }
    }
}
