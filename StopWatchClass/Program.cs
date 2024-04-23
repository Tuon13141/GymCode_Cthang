internal class Program
{
    public static class StopWatch{
        private static DateTime startTime;
        private static DateTime endTime;

        public static void Start(){
            startTime = DateTime.Now;
        }
        public static void Stop(){
            endTime = DateTime.Now;
            TimeSpan timeDifference = endTime - startTime;

            Console.WriteLine("Bấm thời gian: " + timeDifference + "s");
        }
        public static void GetElapsedTime(){
            Random random = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(random.Next());
            }
            Start();
            SelectionSortList(numbers);
            Stop();
        }
    }
    static void SelectionSortList(List<int> numbers)
    {
        int n = numbers.Count;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }
    }

    private static void Main(string[] args)
    {
        StopWatch.GetElapsedTime();
    }
}