internal class Program
{
    public class Fan {
        public static int Slow = 1;
        public static int Medium = 2;
        public static int Fast = 3;
        private int speed = 1;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";
        public Fan(){

        }

        public Fan(int speed, bool on, double radius, string color){
            this.speed = speed;
            this.on = on;
            this.radius = radius;
            this.color = color;
        }
        public void SetSpeed(int speed){
            this.speed = speed;
        }
        public int GetSpeed(){
            return this.speed;
        }

        public void SetOn(bool on){
            this.on = on;
        }
        public bool GetOn(){
            return this.on;
        }

        public void SetRadius(double radius){
            this.radius = radius;
        }
        public double GetRadius(){
            return this.radius;
        }
        
        public void ToString(){
            if(on){
                Console.WriteLine("The fan is on !");
                Console.WriteLine("Speed : " + this.speed);
                Console.WriteLine("Color : " + this.color);
                Console.WriteLine("Radius : " + this.radius);
            }
            else{
                Console.WriteLine("The fan is off !");
                Console.WriteLine("Color : " + this.color);
                Console.WriteLine("Radius : " + this.radius);
            }
        }
    }
    private static void Main(string[] args)
    {
        Fan fan1 = new Fan(Fan.Fast, true, 10, "yellow");
        Fan fan2 = new Fan(Fan.Medium, false, 5, "blue");

        fan1.ToString();
        fan2.ToString();
    }
}