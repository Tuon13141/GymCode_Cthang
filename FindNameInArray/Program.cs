internal class Program
{
    private static void Main(string[] args)
    {
        string [] names = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
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
}