namespace Calculator
{
    public class ArgumentParser
    {
        public bool TryParse(string[] args, out decimal left, out char op, out decimal right)
        {
            left = 0;
            op = '0';
            right = 0;

            string all = string.Join("", args);

            return false;
        }
    }
}
