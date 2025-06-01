namespace OperatorExercise
{
    public class Program
    {

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static void Main(string[] args)
        {
            
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            
            int difference = a - b;
            int product = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}+{b} add values Total is {sum}.");
            Console.WriteLine($"{a}-{b} subtracting value is {difference}.");
            
            Console.WriteLine($"{a}*{b} multiplication is {product}.");
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Please enter radius of Circle you need to calculate");
            double radius=double.Parse(Console.ReadLine());
            Console.WriteLine("Area of your Circle is: "+AreaOfCircle(radius));
            
            

        }
    }
}
