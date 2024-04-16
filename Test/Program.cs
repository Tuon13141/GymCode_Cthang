using System.Timers;
using Timer = System.Timers.Timer;
internal class Program
{
    private static void Timer_Elapsed(object sender, ElapsedEventArgs e, ref int i)
    {
        i++; // Tăng giá trị của biến i mỗi khi Timer_Elapsed được gọi
        
        Console.WriteLine($"Giá trị của biến i là: {i}");

        // Thực hiện các công việc khác ở đây
    }
    private static void Main(string[] args)
    {
        int i = 0; // Biến được truyền vào Timer_Elapsed

        Timer timer = new Timer(1000);
        
        // Sử dụng phương thức đối tượng để truyền biến i vào Timer_Elapsed
        timer.Elapsed += (sender, e) => Timer_Elapsed(sender, e, ref i);

        timer.Start();

        Console.WriteLine("Nhấn phím bất kỳ để dừng chương trình.");
        Console.ReadKey();
        timer.Stop();
    }
}