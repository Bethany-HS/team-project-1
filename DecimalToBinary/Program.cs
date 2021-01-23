using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working Code, but now going to try to implement converting double to binary double...
            // May be going down a rabbit hole.
            /*
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
            */

            int precision = 0;

            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string[] decimalValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.Write("\nPlease enter how many binary decimal places you would like: ");
            precision = int.Parse(Console.ReadLine());

            for (int i = 0; i < decimalValues.Length; i++)
            {
                string reversePolishNotation = "";
                double baseTen = double.Parse(decimalValues[i]);
                int wholeTen = Convert.ToInt32(baseTen);
                double fractionalTen = baseTen - wholeTen;

                while (wholeTen > 0)
                {
                    int remainder = wholeTen % 2;
                    wholeTen /= 2;
                    reversePolishNotation = remainder + reversePolishNotation;
                }
                reversePolishNotation += ".";
                for(int j = 0; j < precision && fractionalTen != 0; j++)
                {
                    fractionalTen *= 2;
                    reversePolishNotation += fractionalTen >= 1 ? 1 : 0;
                    fractionalTen = fractionalTen >= 1 ? fractionalTen - 1 : fractionalTen - 0;
                }
                Console.WriteLine($"{decimalValues[i]} in binary is {reversePolishNotation}");
            }
        } 

      

    }
}
