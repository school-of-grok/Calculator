using System;

namespace Calculator
{
	public class CalculatorEngine
    {
        private ArgumentParser _parser = new ArgumentParser();
        private decimal _lastResult = 0;

        public decimal? Calculate(string arg)
        {
            return Calculate(new[] {arg});
        }

        public decimal? Calculate(string[] args)
        {
            if (!_parser.TryParse(args, out decimal? left, out char op, out decimal right))
            {
                return null;
            }

            if (left is null)
            {
                left = _lastResult;
            }

            decimal? result;

            switch (op)
            {
                case '+':
                    result = left + right;
                    break;
                case '-':
                    result = left - right;
                    break;
                case '*':
                    result = left * right;
                    break;
                case '/':
                    result = left / right;
                    break;
                default:
                    Console.WriteLine("Error: operator not recognized");
                    result = null;
                    break;
            }

            if (result is not null)
            {
                _lastResult = result.Value;
            }

            return result;
        }
    }
}
