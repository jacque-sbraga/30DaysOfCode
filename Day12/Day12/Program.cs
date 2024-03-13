namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> results = new List<int>();
            
            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            for(int i = 0; i < arr.Count-2;i++) { 
                for(int j = 0; j < arr.Count-2;j++) { 
                
                    int top = arr[i][j] + arr[i][j+1] + arr[i][j+2];
                    int middle = arr[i + 1][j + 1];
                    int bottom = arr[i+2][j] + arr[i + 2][j+1] + arr[i+2][j+2];
                    results.Add(top+middle+bottom);
                }
            }
            Console.WriteLine(results.Max());
        }
    }
}
