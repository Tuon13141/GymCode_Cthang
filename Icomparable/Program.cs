internal class Program
{
    public class Circle{
        private double radius;
        private string color;
        private bool filled;
        public Circle(){

        }
        public Circle(double radius){
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled){
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }

        public double getRadius(){
            return radius;
        }
    }
    public class ComperableCircle : Circle, IComparable<ComperableCircle>
    {

        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComperableCircle o)
        {
            if (getRadius() > o.getRadius()) return 1;
            else if (getRadius() < o.getRadius()) return -1;
            else return 1;
        }
    }
    private static void Main(string[] args)
    {
        ComperableCircle[] circles = new ComperableCircle[3];
      circles[0] = new ComperableCircle(3.6);
      circles[1] = new ComperableCircle();
      circles[2] = new ComperableCircle(3.5, "indigo", false);

      Console.WriteLine("Pre-sorted:");
      foreach (ComperableCircle circle in circles)
      {
            Console.WriteLine(circle.getRadius());
      }

      Array.Sort(circles);

      Console.WriteLine("After-sorted:");
      foreach (ComperableCircle circle in circles)
      {
            Console.WriteLine(circle.getRadius());
      }
    }
}