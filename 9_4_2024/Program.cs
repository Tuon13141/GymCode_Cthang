internal class Program
{
    static void B1(){
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

    static void B2(){
        string [] names = {"Mai", "An", "Hoa"};
        Console.WriteLine("Nhap ten muon tim : ");
        string findName = Console.ReadLine();
        int index = 0;
        foreach(string name in names){
            index++;
            if(findName.ToLower().Equals(name.ToLower())){              
                Console.WriteLine("Da tim thay ten : " + name + ". La phan tu thu : " + index);
                return;
            }

        }

        Console.WriteLine("Khong ton tai ten do !");
    }
    private static void Main(string[] args)
    {
        B2();
    }
}