using Shape;
internal class Program
{
    private static void Main(string[] args)
    {
        Shape.Shape shape = new Shape.Shape("blue", true);
        Console.WriteLine(shape.ToString());
        Console.WriteLine();

        List<ResizeableAndColortableShape> ResizeableAndColortableShape= new List<ResizeableAndColortableShape>(){
            new Circle(1, "yellow", false),
            new Rectangle(2, 2, "red", true),
            new Square(3, "black", true),
        };
        foreach(ResizeableAndColortableShape rshape in ResizeableAndColortableShape){
            Console.WriteLine("Before : ");
            Console.WriteLine(rshape.ToString());
            Random random = new Random();
            rshape.Resize(random.NextInt64(100, 200));
            Console.WriteLine("After : ");
            Console.WriteLine(rshape.ToString());
            rshape.HowToColor();
            Console.WriteLine();
        }
    }
}

