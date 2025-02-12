using System;
using System.Collections.Generic;
using System.Linq;


namespace MyfirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] GrandLotto = new int[6];

            for (int i = 0; i < GrandLotto.Length; i++)
            {
                int LottoMachine;
                do
                {
                    LottoMachine = random.Next(0, 58); // Generates numbers between 0 and 58 inclusive. Change 60 if needed.
                } while (GrandLotto.Contains(LottoMachine)); // Check if the number is already in GrandLotto

                GrandLotto[i] = LottoMachine; // Add the unique number to the array
            }

            Console.WriteLine("Grand Lotto numbers:");
            Console.WriteLine(string.Join(", ", GrandLotto));
            Console.WriteLine("Hi");
            Console.WriteLine("Another Hi");

        }
    }
}