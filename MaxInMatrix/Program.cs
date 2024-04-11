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

        int max = matrix[0, 0];
        int x = 0;
        int y = 0;
        Console.WriteLine("Ma tran : ");
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                Console.Write(matrix[i, j] + " ");
                if(max < matrix[i, j]){
                    max = matrix[i, j];
                    x = i;
                    y = j;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Max trong ma tran : " + max + ", o vi tri [" + x + ", " + y + "]");
    }
}