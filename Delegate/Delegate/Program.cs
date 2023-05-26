namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static int Add(int x, int y)
        {
            Console.WriteLine($"Add: {x} + {y} = {x + y}");
            return x + y;
        }
        static int Divide(int x, int y)
        {
            Console.WriteLine($"Add: {x} / {y} = {x / y}");
            return x / y;
        }
        static int Subtract(int x, int y)
        {
            Console.WriteLine($"Add: {x} - {y} = {x - y}");
            return x - y;
        }
        static int Multiply(int x, int y)
        {
            Console.WriteLine($"Add: {x} * {y} = {x * y}");
            return (x * y);
        }
    }
}