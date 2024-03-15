using System.Collections.Generic;

namespace WorkingWithDirectory 
{

    class Program
    {
        static void Main(string[] args)
        {
            string path ="myfolder";

            try
            {
                var folders= Directory.EnumerateDirectories(path,"*.*",SearchOption.AllDirectories);
                var files= Directory.EnumerateFiles(path,"*.*",SearchOption.AllDirectories);
                
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
                Directory.CreateDirectory(path+@"newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}