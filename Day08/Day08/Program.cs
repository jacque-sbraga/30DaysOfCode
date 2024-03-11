namespace Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            string result = "";
            for (int i = arr.Count-1; i >= 0; i--)
            {
                result += $"{arr[i]} ";
            }

            Console.WriteLine(result.Trim());
        }
    }
}
