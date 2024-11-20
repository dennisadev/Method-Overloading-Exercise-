using System.Text.RegularExpressions;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numOne, int numTwo)
        { 
            return numOne + numTwo; 
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }
        
        public static string Add(int numOne, int numTwo, bool isCurrency)
        {
            var sum = numOne + numTwo;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else 
            { 
                return sum.ToString();
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(8, 8, true));
            Console.WriteLine(Add(8, 8, false));
        }
    }
}
