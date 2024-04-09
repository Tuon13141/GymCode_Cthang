internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu trong mang : ");
        int a = int.Parse(Console.ReadLine());
        int[] b = new int[a];
        int sum = 0;
        for(int i = 0; i < a; i++){
            Console.WriteLine("Nhap phan tu thu " + (i+1));
            b[i] = int.Parse(Console.ReadLine());
            sum+=b[i];
        }
        Console.WriteLine("Cac phan tu trong mang : ");
        for(int i = 0; i < a; i++){
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Tong cua mang : " + sum);

    }
}