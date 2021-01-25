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
                int wholeTen = Convert.ToInt32(baseTen);        // The whole number of the Decimal value
                double fractionalTen = baseTen - wholeTen;      // The fractional part of the Decimal value

                // Calculate the Binary for the whole part
                while (wholeTen > 0)
                {
                    // By finding the remainder by repeatedly dividing by zero we can build our Binary number
                    int remainder = wholeTen % 2;
                    // Then we need to reduce the size of the whole number so we are not in an infinite loop
                    wholeTen /= 2;
                    // Add the remainder to the count, and we need to add it in the position of most significance
                    reversePolishNotation = remainder + reversePolishNotation;
                }

                // insert the decimal point into our soon to be fracionary Binary number
                reversePolishNotation += ".";

                // Calculate the Binary for the fractional part
                for(int j = 0; j < precision && fractionalTen != 0; j++)
                {
                    // This time we need to repeatedly multiply by 2 to find the when the fractionary part becomes a whole number
                    fractionalTen *= 2;
                    // If the number is greater than, or equal to one, then we put a "1" in that place for out Binary number, else a "0"
                    reversePolishNotation += fractionalTen >= 1 ? 1 : 0;
                    // If the number is greater than 1, then we need to remove it so that all future doubles are not greater than 1 unles they are because of the double
                    fractionalTen = fractionalTen >= 1 ? fractionalTen - 1 : fractionalTen - 0;
                }
                Console.WriteLine($"{decimalValues[i]} in binary is {reversePolishNotation}");
            }
        } 

      

    }
}
