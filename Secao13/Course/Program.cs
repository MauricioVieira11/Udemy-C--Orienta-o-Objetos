using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Tecnologia\GuiaOracle.txt";
            string targetPath = @"D:\Tecnologia\GuiaOracle2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurent");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
