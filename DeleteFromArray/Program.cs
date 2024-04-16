using System.Text.Json.Serialization;

internal class Program
{
    public static void DeleteFromArray(int[] array){
        Console.WriteLine("Nhap phan tu muon xoa");
        int a = int.Parse(Console.ReadLine());

        for(int i = 0; i < array.Length; i++){
            if(array[i] == a){
                for(int j = i; j < array.Length - 1; j++){
                    array[j] = array[j + 1];
                } 
                Array.Resize(ref array, array.Length - 1);
            }
        }

        ArrayOutput(array); 
    }

    public static int[] ArrayInput(int n){
        int[] array = new int[n];
        for(int i = 0; i < n; i++){
            Console.WriteLine("Nhap phan tu thu : " + (i + 1));
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    public static void ArrayOutput(int[] array){
        Console.WriteLine("Mang : ");
        foreach(int i in array){
            Console.Write(i + " ");
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong mang :");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        array = ArrayInput(n);
        DeleteFromArray(array);
    }
}