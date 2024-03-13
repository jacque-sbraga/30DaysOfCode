namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            string binary = Convert.ToString(n, 2);
            

            int result = 0;
            int maxNumber = 0;

            foreach(char c in  binary)
            {
                if(c == '1')
                {
                    result++;
                } else
                {
                    result = 0;
                }
                if(result > maxNumber)
                {
                    maxNumber = result;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
