using System;
using System.IO;


namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"D:\Tecnologia\GuiaOracle.txt";
            string TargetPath = @"D:\Tecnologia\GuiaOracle2.txt";
            
            try
            {
                string[] lines = File.ReadAllLines(SourcePath);
                /*
                using StreamReader sw = File.AppendText(TargetPath)){
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }

                }*/

            }
            catch (IOException e)
            {
                Console.WriteLine("An Error occured");
                Console.WriteLine(e.Message);
            }

        }
    }
}
