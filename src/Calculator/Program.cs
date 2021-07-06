using System;

namespace Calculator
{
	class Program
    {
        static void Main(string[] args)
        {
            var engine = new CalculatorEngine();

            decimal? result = engine.Calculate(args);

            Console.WriteLine(result);
        }
    }
}
