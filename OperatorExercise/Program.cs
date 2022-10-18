using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            int quotient = (a / b);
            int remainder = (a % b);
            if (a == 17 && b == 4)
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            else
                Console.WriteLine("false");

            // Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var results = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {results}");
            
        }

        static double AreaOfCircle(double radius)
        {
            
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

    }
}