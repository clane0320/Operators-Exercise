namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine("Enter radius of the circle." );
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);
            Console.WriteLine(AreaOfCircle(radius));

            
        }

        public static int AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            
            
            return (int)area;
        }

    }
}
