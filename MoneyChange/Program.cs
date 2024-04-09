internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so dola can doi : ");
        float dola = float.Parse(Console.ReadLine());

        float vnd = dola * 23000;
        Console.WriteLine("So tien vnd sau khi doi : " + vnd);
    }
}