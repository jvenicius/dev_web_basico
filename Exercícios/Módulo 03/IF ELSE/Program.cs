using System;

namespace controle
{
    class Program
    {
        static void Main(string[] args)
        {

            // IF/ELSE
            bool condition = true;

            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }
           
            // Exemplos:
            /*
            // Ex 1.:

            int m = 12;
            int n = 18;

            if (m > 10 && n > 20)
            {
                Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2");
            }
            */

            // Ex 2.:

            int m = 12;
            int n = 8;

            if (m > 10 && n > 20)
            {
                Console.WriteLine("Result1");
            }
            else
            {
                Console.WriteLine("Result2"); 
            } 

            // SWITCH/CASE
            
            
        }
    }
}
