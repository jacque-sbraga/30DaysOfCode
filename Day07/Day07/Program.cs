namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                string evenIndex = "";
                string oddIndex = "";

                for(int j = 0; j < S.Length; j++)
                {
                    if (j % 2 == 0)
                        evenIndex += S[j];
                    else 
                        oddIndex += S[j];
                }

                Console.WriteLine($"{evenIndex} {oddIndex}");
               
            }

        }
    }
}
