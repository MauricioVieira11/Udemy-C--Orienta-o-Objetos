using System;

namespace StringsInteressantes
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original); //ver se a variável está vazia
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original:"+original);
            Console.WriteLine("Todas Maiúscula: "+s1);
            Console.WriteLine("Tudo minúsculas: "+s2);
            Console.WriteLine("Trim: " +s3); // apaga espaços em branco no início e fim
            Console.WriteLine("INdexOf bc: "+n1); //começa na posição 1 do bc
            Console.WriteLine("LastINdexOff: "+n2);
            Console.WriteLine("Substring 3: "+s4);
            Console.WriteLine("Substring 3,5: "+s5);
            Console.WriteLine("Replace: "+s6);
            Console.WriteLine("Replace: "+s7);
            Console.WriteLine("isNullOrEmpty: "+b1);
            Console.WriteLine("IsNullOrEmpty: "+b2);
        
        }
    }
}
