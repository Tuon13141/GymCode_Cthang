internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu trong mang : ");
        int a = int.Parse(Console.ReadLine());
        int[] b = new int[a];
        int max = 0;
        int index = 0;
        for(int i = 0; i < a; i++){
            Console.WriteLine("Nhap phan tu thu " + (i+1));
            b[i] = int.Parse(Console.ReadLine());
            if(max <= b[i]){
                max = b[i];
                index = i + 1;
            }

        }
        Console.WriteLine("Cac phan tu trong mang : ");
        for(int i = 0; i < a; i++){
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Phan tu Max cua mang : " + max + ", la phan tu thu : " + index);
    }
}