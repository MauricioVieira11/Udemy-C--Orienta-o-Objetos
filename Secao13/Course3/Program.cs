using System;
using System.IO;


namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = @"D:\Tecnologia\GuiaOracle.txt";
            try {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                
            } catch(IOException e)
            {
                Console.WriteLine("An Error occured");
                Console.WriteLine(e.Message);
            }

        }
    }
}
