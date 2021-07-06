using System;

namespace Calculator
{
	public class CalculatorEngine
    {
        public decimal? Calculate(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: calculator left op right");
                return null;
            }

            if (!decimal.TryParse(args[0], out decimal left))
            {
                Console.WriteLine("Error: left value is not a number");
                return null;
            }

            if (!decimal.TryParse(args[2], out decimal right))
            {
                Console.WriteLine("Error: right value is not a number");
                return null;
            }

            decimal result;

            if (args[1] == "+")
            {
                result = left + right;
            }
            else if (args[1] == "-")
            {
                result = left - right;
            }
            else if (args[1] == "*")
            {
                result = left * right;
            }
            else if (args[1] == "/")
            {
                result = left / right;
            }
            else
            {
                Console.WriteLine("Error: operator not recognized");
                return null;
            }

            return result;
        }
    }
}
