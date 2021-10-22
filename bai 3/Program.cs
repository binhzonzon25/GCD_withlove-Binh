using System;

namespace bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("---------------------------");
            Console.Write("Nhap n: ");
            int num = int.Parse(Console.ReadLine());
            for(int i =1; i< num; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine("---------------------------");
        for (int i=1; i<=num; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine("");

            }
            Console.WriteLine("---------------------------");
        for (int i=1; i<=10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");           
            }    
        }
    }
}
