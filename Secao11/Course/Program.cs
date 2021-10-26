using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("Division by zero is not!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! "+e.Message);
            }
            finally //executa algo independente de dar certo ou não: fecha arqivo ou conexão com o banco, por exemplo.
            {

            }
            //OBS: posso colcoar um tratamento de erro num relatório onde tenha que escrever um cpf do tipo int, mas
            //o usuário digita letras.
        }
    }
}
