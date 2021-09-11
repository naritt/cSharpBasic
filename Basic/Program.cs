using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i <= 12;i++)
            {
                int result = number * i;
                //Console.WriteLine(number + " x " + i + " = " + result);
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
