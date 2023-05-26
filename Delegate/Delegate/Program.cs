namespace Delegate
{
    internal class Program
    {
        public delegate int Operation(int x, int y);
        
        static void Main(string[] args)
        {
            Operation operation = Add;
            operation += Divide;
            operation += Subtract;
            operation += Multiply;

            operation(5, 5);
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