using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ----- POSSO SER DOADOR DE SANGUE? ----- \n");
                    
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Qual a sua idade? ");
            bool idade2 = Int32.TryParse(Console.ReadLine(), out idade);

             if (idade >=18 && idade <=67)
                 Console.WriteLine("Você pode ser doador de sangue.");

             else
                Console.WriteLine("Você não pode ser doador de sangue.");
            
            Console.WriteLine ("Pressione enter para finalizar.");
            Console.ReadKey(); 
        }  
    }
}
