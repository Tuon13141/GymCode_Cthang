internal class Program
{
    public class BPTB1
    {
        int a;
        int b;

        public BPTB1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Solve()
        {
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Nghiem x = " + CalX());
            }
        }
        public float CalX()
        {
            return -(float)b / a;
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("a.x + b = 0");
        Console.WriteLine("Nhap a : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap b : ");
        int b = int.Parse(Console.ReadLine());

        BPTB1 bpt = new BPTB1(a, b);
        bpt.Solve();
    }
}