using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new CalculatorEngine();

            if (args.Length > 0)
            {
                decimal? result = engine.Calculate(args);
                if (result is null)
                {
                    Console.WriteLine("Usage: calculator left op right");
                }
                else
                {
                    Console.WriteLine(result);
                }
                return;
            }

            Console.WriteLine("Enter q to quit");
            while (true)
            {
                Console.Write("> ");
                var sum = Console.ReadLine();

                if (sum == "q") break;

                if (EasterEggs.TryGetEgg(sum, out var egg))
                {
                    Console.WriteLine($"  {egg}");
                    continue;
                }

                decimal? result = engine.Calculate(sum);
                if (result is null)
                {
                    Console.WriteLine("Didn't understand that.");
                }
                else
                {
                    Console.WriteLine($"  {result}");
                }
            }
        }
    }
}
