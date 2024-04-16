internal class Program
{
    public static void CountLetter(char letter, string input){
        int count = 0;
        int index = 1;
        foreach(char c in input){
            if(letter == c){
                count++;
                Console.WriteLine("Phat hien ki tu trung o thu tu thu : " + index);
            }
            index++;
        }

        Console.WriteLine("Tong so ki tu da dem duoc : " + count);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chuoi string :");
        string input = Console.ReadLine();
        Console.WriteLine("Nhap ki tu can dem : ");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();
        CountLetter(letter, input);
    }
}