using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string[] decimalValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < decimalValues.Length; i++)
            {
                string reversePolishNotation = "";
                int baseTen = int.Parse(decimalValues[i]);
                while (baseTen > 0)
                {
                    int remainder = baseTen % 2;
                    baseTen = baseTen / 2;
                    reversePolishNotation = remainder + reversePolishNotation;
                }
                Console.WriteLine($"{decimalValues[i]} in binary is {reversePolishNotation}");
            } 
        } 

      

    }
}
