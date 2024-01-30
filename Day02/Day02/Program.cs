namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine()!);
            double numberB = double.Parse(Console.ReadLine()!);
            string text = Console.ReadLine()!;

            // the variables i, d and s are already declared in the submission platform.
            //Console.WriteLine(numberA + i);
            //Console.WriteLine((numberB + d).ToString("0.0"));
            //Console.WriteLine(s + text);
            Console.WriteLine(numberA + numberB);
            Console.WriteLine((numberB + numberB).ToString("0.0"));
            Console.WriteLine("HackerRank " + text);
        }
    }
}
