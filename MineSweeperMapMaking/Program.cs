internal class Program
{
    static void MineSweeper(){
        Console.WriteLine("Nhap thong tin ma tran :");
        Console.WriteLine("Chieu rong : ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Chieu dai : ");
        int y = int.Parse(Console.ReadLine());

        int[,] matrix = new int[x,y];
        matrix = SetMine(matrix, x, y);

        Console.WriteLine("===Map===");
        PrintMap(matrix, x, y);
    }

    static void PrintMap(int[,] matrix, int x, int y){
        for(int i = 0; i < y; i++){
            for(int j = 0; j < x; j++){
                if(matrix[j, i] == -1){
                    Console.Write("* ");
                }
                else{
                    Console.Write(matrix[j, i] + " ");
                }              
            }
            Console.WriteLine();
        }
    }

    static int[,] SetMine(int[,] matrix, int x, int y){
        Console.WriteLine("Setup bom trong ma tran : ");
        Console.WriteLine("Nhap so luong bom :");

        int bomTotal = int.Parse(Console.ReadLine());
        for(int i = 0; i < bomTotal; i++){
            Console.WriteLine("Nhap thong tin cua bom thu " + (i+1));
            Console.WriteLine("Nhap x cua bom : ");
            int xBom = int.Parse(Console.ReadLine());
            while(xBom >= x || xBom < 0){
                Console.WriteLine("Nhap lai x cua bom : ");
                xBom = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap y cua bom : ");
            int yBom = int.Parse(Console.ReadLine());
            while(yBom >= y || yBom < 0){
                Console.WriteLine("Nhap lai y cua bom : ");
                yBom = int.Parse(Console.ReadLine());
            }
            matrix[xBom, yBom] = -1;
           
            matrix = CreateNearbyArea(matrix, xBom, yBom, x, y);
        } 

        return matrix;
    }
    static int CheckStartCondition(int a){
        a -= 1;
        if(a < 0){
            a = 0;
        }
        return a;
    }

    static int CheckEndCondition(int a, int b){
        a += 1;
        if(a >= b){
            a = b - 1;
        }
        return a;
    }
    static int[,] CreateNearbyArea(int[,] matrix, int xBom, int yBom, int x, int y){
        int xStart = CheckStartCondition(xBom);
        int yStart = CheckStartCondition(yBom);

        int xEnd = CheckEndCondition(xBom, x);
        int yEnd = CheckEndCondition(yBom, y);

        for(int i = yStart; i <= yEnd; i++){
            for(int j = xStart; j <= xEnd; j++){
                if(matrix[j, i] != -1){
                    matrix[j, i] += 1;
                }
            }           
        }

        return matrix;
    }
    private static void Main(string[] args)
    {
        MineSweeper();
    }
}