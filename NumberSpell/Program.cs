internal class Program
{
    public class NumberSpell
    {
        int a;

        public NumberSpell(int a)
        {
            this.a = a;
        }

        public void Solve()
        {
            string spell = "";
            int loopCount = 0;
            while(a > 0)
            {
     
                    switch(loopCount)
                    {
                        case 1:
                            if(a % Math.Pow(10, loopCount) == 1)
                                spell = "Mười " + spell;
                            else 
                                spell = "Mươi " + spell;
                            break;
                        case 2:
                            spell = "Trăm " + spell;
                            break;
                        case 3:
                            spell = "Nghìn " + spell;
                            break;
                        case 4:
                            spell = "Mươi nghìn " + spell;
                            break;
                        case 5:
                            spell = "Trăm nghìn " + spell;
                            break;
                    }
                
                
                int remainder = a % 10;
                a /= 10;
                
                switch(remainder)
                {
                    case 0:
                        if(a <= 0 && loopCount == 0)
                        {
                            spell += "Không";
                        }                 
                        break;
                    case 1:                   
                        if(loopCount == 0){
                            if(a % 10 == 1 || a == 0){
                                spell += "Một";
                            }
                            else
                                spell += "Mốt";
                        }
                        else if(loopCount > 0  && loopCount != 1){
                            spell = "Một " + spell;
                            break;
                        }
                        break;
                    case 2:
                        spell = "Hai " + spell;
                        break;
                    case 3:
                        spell = "Ba " + spell;
                        break;
                    case 4:
                        spell = "Bốn " + spell;
                        break;
                    case 5:
                        spell = "Năm " + spell;
                        break;
                    case 6:
                        spell = "Sáu " + spell;
                        break;
                    case 7:
                        spell = "Bẩy " + spell;
                        break;
                    case 8:
                        spell = "Tám " + spell;
                        break;
                    case 9:
                        spell = "Chín " + spell;
                        break;
                }

                loopCount++;
                //Console.WriteLine("spell = " + spell);
            }
            
            Console.WriteLine(spell);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Đánh vần số : ");
        Console.WriteLine("Nhập số lần nhập : ");
        int total = int.Parse(Console.ReadLine());
        while (total > 0){
            Console.WriteLine("Nhập số cần đánh vần : ");
            int a = int.Parse(Console.ReadLine());

            NumberSpell numberSpell = new NumberSpell(a);
            numberSpell.Solve();

            total --;
        }
    }
}