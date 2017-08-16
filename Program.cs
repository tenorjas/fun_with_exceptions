using System;

namespace fun_with_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****\nI'm done!!!\n****\n");
        }

        public static int divideInts(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("Can not divide by 0.");
                throw;
            }
            
        }

        public static int getSafeInt()
        {
                try
                {
                    Console.WriteLine("Enter an integer.");
                    return int.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("You did not enter an integer.  Please try again.");
                    throw;
                }
        }
            
        

        public static int sumOfNumbers(int[] numbers, int length)
        {
            try
            {
                int total = 0;
                foreach (var num in numbers)
                {
                    total += num;
                }
                return total;
            }
            catch (System.Exception)
            {
                Console.WriteLine("The operands are not valid.  Please try again.");
                throw;
            }
        }
    }
}
