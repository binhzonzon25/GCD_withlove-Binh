using System;

namespace test_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            /*int sum = 0;
            for(int i=0; i<=num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"{sum}");*/
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }    
        }
    }
}
