using System;

namespace btvn_4
{
    class Program
    {
        
        static double sum(int a , int b)
        {
            
           double  tong = a + b;
            return tong;
        }
        static int power(int baseNumber, int exponent)
        {
            int result = 1;
            for(int i=1; i<=exponent; i++)
            {
                result = result  * baseNumber;
            }

            return result;
        }
        static void change(int a, int b)
        {
            int keep = a;
            a = b;
            b = keep;
            Console.WriteLine($"ket qua doi la {a},{b}");
        }
        static void information(string name,int age,string sex)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Sex {sex}");              
        }


        static void Main(string[] args)
        {
            change(1,2);
            Console.WriteLine($" {power(2, 4)}");
            information("Binh", 20, "Male");
        }
    }
}
