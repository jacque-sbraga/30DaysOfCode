namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (N <= 5 || N > 20)
                {
                    Console.WriteLine("Not Weird");
                }
                else
                {
                    Console.WriteLine("Weird");
                }
                
            }

        }
    }
}
