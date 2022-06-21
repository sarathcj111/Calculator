namespace Calculator
{
    internal class Program
    {
        public double rem(double x, double y)
        {
            return x % y;
        }
        public double pow(double x, double y)
        {
            return Math.Pow(x, y); ;
        }
        public double per(double x, double y)
        {
            return (x / y) * 100;
        }
        public double mul(double x, double y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Choose the operation\n1 Remainder\n2 Power\n3 Percentage\n4 Multiply");
            int operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Program obj = new Program();
            double res = 0;
            switch (operation)
            {
                case 1:
                    res = obj.rem(x,y);
                    Console.WriteLine("Result is " + res + "\n");
                    break;

                case 2:
                    res = obj.pow(x, y);
                    Console.WriteLine("Result is " + res + "\n");
                    break;

                case 3:
                    res = obj.per(x, y);
                    Console.WriteLine("Result is " + res + "\n");
                    break;

                case 4:
                    res = obj.mul(x, y);
                    Console.WriteLine("Result is " + res + "\n");
                    break;
            }
            goto start;

        }
    }
}