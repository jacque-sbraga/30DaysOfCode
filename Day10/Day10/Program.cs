namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(3));
        }

        public static int factorial(int x)
        {
            
            return x <= 1 ? 1 : x * factorial(x - 1);
        }
    }
}
