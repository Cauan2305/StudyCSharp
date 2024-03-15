using System.IO;
namespace WorkWithFilesInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
        //  string sourcePath="file1.txt";
        //  string targetPath="file2.txt";
         
        //  try
        //  {
        //     FileInfo fileInfo = new FileInfo(sourcePath);
        //     // fileInfo.CopyTo(targetPath);
        //     string[] lines= File.ReadAllLines(sourcePath);
        //     foreach (string linha in lines)
        //     {
        //         Console.WriteLine(linha);
        //     }
        //  }  
        //  catch(IOException e)
        //  {
        //     Console.WriteLine(e.Message);
        //  } 


        // FileStream fs=null;
        // StreamReader sr=null;

        // try{
        //     // fs= new FileStream(sourcePath,FileMode.Open);
        //     // sr= new StreamReader(fs);

        //     // Outra forma de usar FileStream e o StreamReader
        //     sr= File.OpenText(sourcePath);
        //     while (!sr.EndOfStream)
        //     {
        //         string line = sr.ReadLine();
        //         Console.WriteLine(line);

        //     }

        // }
        // catch (IOException e)
        // {   
        //     Console.WriteLine(e.Message);
        // }
        // finally 
        // {
        //     if (sr != null )sr.Close();
        //     if (fs != null) fs.Close();

        // }

        // Using Block

        // string path ="file1.txt";
        // try{
        //     using (FileStream fs = new FileStream(path,FileMode.Open))
        //     {
        //         using (StreamReader sr = new StreamReader(fs))
        //         {
        //             while(!sr.EndOfStream)
        //             {
        //                 Console.WriteLine(sr.ReadLine());
        //             }
        //         }
        //     }
        // }
        // catch (IOException e )
        // {
        //     Console.WriteLine(e.Message);
        // }


        string path ="file1.txt";
        string path2 ="file2.txt";

        // try{
        //     using (StreamReader sr = File.OpenText(path))
        //     {
        //         while(!sr.EndOfStream)
        //         {
        //             Console.WriteLine(sr.ReadLine());
        //         }
        //     }
        // }
        // catch (IOException e )
        // {
        //     Console.WriteLine(e.Message);
        // }


        // StreamWritter


        try{
            string[]  lines = File.ReadAllLines(path);
            using (StreamWriter sw = new StreamWriter(path2))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e )
        {
            Console.WriteLine(e.Message);
        }
    }
    }
}