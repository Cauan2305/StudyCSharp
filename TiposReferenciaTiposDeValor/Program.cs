namespace TiposReferenciaTiposDeValor
{
   class Program 
   {
        static void Main(string [] args)
        {
            // Product p , p2;
            // p=new Product();
            // p2=p;
            
            // p.Name="Cauan";
            // p.Valor=12.00;

            // // Aqui ele Vai Criar um ponteiro , apontando o stack para heap , onde no stack  vai esta o endereço da memeoria 

            // //  E Se Caso EU Fizer isso Aqui 
            // Console.WriteLine(p2.Valor);
            // p2.Valor=322.111;
            // Console.WriteLine(p2.Valor);
            // Console.WriteLine(p.Valor);

            // Ele vai colocar no Stack do p2 o mesmo endereço do p1 
            // Ele Vai Estar Fazendo Referencia ao Objeto p1 
            // Tudo Que EU Mudar no p1 vai mudar no p2 


            // Agora Nos Vamos Usar o Struct 
            // o p2 Aqui Ele So Vai Criar uma Copia do p
            ProductStruct p, p2;
            p=new ProductStruct();
            

            p.Name="Cauan";
            p.Valor=12.122;
            p2=p;
            
            Console.WriteLine($"p.Name= {p.Name}\n p2.Name= {p2.Name}");
            Console.WriteLine("===================");
            // Caso eu Altere o p2 o p nao vai mudar nada porque ele nao esta sendo referenciado na mesma memoria 
            p2.Name="Caio";
            Console.WriteLine($"p.Name= {p.Name}\n p2.Name= {p2.Name}");


        }
   }
}