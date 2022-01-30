using System;
using System.Collections.Generic;

namespace repeticoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var fibNumbers = new List<int>{ 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                Console.WriteLine($"Elemento #{count}: {element}");
                count++;
            }
            
            Console.WriteLine($"Número de elementos: {count}");

            // FOR
            for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                 }

            // WHILE
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine($"Valor: {n}");
                n++;
            }   
            */
            // WHILE break
            int n = 0;
            while (n < 5)
            {
                n++;
                if (n>2)
                {
                    break;
                }                
                Console.WriteLine(n);
            }            
        }
    }
}
