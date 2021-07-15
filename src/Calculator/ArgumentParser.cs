using System;

namespace Calculator
{
    public class ArgumentParser
    {
        public bool TryParse(string[] args, out decimal? left, out char op, out decimal right)
        {
            string all = string.Join("", args);
            return TryParse(all, out left, out op, out right);
        }

        public bool TryParse(string args, out decimal? left, out char op, out decimal right)
        {
            left = 0;
            op = '0';
            right = 0;

            var span = args.AsSpan();

            ReadOnlySpan<char> leftSpan = default, rightSpan = default;

            for (int i = 0; i < span.Length; i++)
            {
                char c = span[i];

                if (IsOperator(c))
                {
                    op = c;
                    leftSpan = span.Slice(0, i);
                    rightSpan = span.Slice(i + 1);
                    break;
                }
            }

            left = null;
            if (leftSpan.Length > 0)
            {
                if (decimal.TryParse(leftSpan, out decimal value))
                {
                    left = value;
                }
                else
                {
                    right = default;
                    return false;
                }
            }

            return decimal.TryParse(rightSpan, out right);
        }

        private bool IsOperator(char c)
        {
            return c is '+' or '-' or '*' or '/';
        }
    }
}
