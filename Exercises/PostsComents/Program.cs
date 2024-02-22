using PostsComents.Entities;
namespace PostsComents
{
    class Program
    {
        static void   Main( string[] args)
        {
            
            Comment c1 = new Comment("Nice Photo");
            Comment c2 = new Comment("Nice Photo1");

            Post p1=new Post(DateTime.Now,"Travel to Canada","Photo",100);

            p1.AddComent(c1);
            p1.AddComent(c2);

            Console.Write(p1);

        }
    }
}