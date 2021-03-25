using System;

namespace Exercicio_Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep(); 
            
            String Leet;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------Escreva qualquer coisa---------------");
            Console.ResetColor();
            Console.Write("Escreva algo: ");
            Leet = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Tradução: ");
            Console.WriteLine($"{Leet.Replace("a", "4").Replace("A", "4").Replace("E", "3").Replace("e", "3").Replace("i", "1").Replace("I", "1").Replace("l", "1").Replace("L", "1").Replace("S", "5").Replace("s", "5").Replace("o","0").Replace("O","0")}");
            Console.ResetColor();
           
        }
    }
}
