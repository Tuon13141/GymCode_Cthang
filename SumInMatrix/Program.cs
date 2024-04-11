internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];
        matrix[0, 0] = 1;
        matrix[1, 0] = 2;
        matrix[2, 0] = 3;
        matrix[0, 1] = 4;
        matrix[1, 2] = 15;
        matrix[2, 2] = 6;

        int sum = 0;
        Console.WriteLine("Ma tran : ");
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                Console.Write(matrix[i, j] + " ");
                sum += matrix[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tong ma tran : " + sum);
    }
}