internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu trong mang : ");
        int a = int.Parse(Console.ReadLine());
        int[] b = new int[a + 1];

        for(int i = 0; i < a; i++){
            Console.WriteLine("Nhap phan tu thu " + (i+1));
            b[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("Cac phan tu trong mang : ");
        for(int i = 0; i < a; i++){
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Nhap vi tri muon them vao mang : ");
        int index = int.Parse(Console.ReadLine());
        while(index > a + 1){
            Console.Write("Nhap lai ");
            index = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Nhap gia tri muon them vao mang : ");
        int value = int.Parse(Console.ReadLine());

        for(int i = a; i >= index; i--){
            b[i] = b[i-1];
        }

        b[index - 1] = value;

        Console.WriteLine("Cac phan tu trong mang sau thay doi: ");
        for(int i = 0; i < a + 1; i++){
            Console.Write(b[i] + " ");
        }
    }
}