using System;

namespace bai2
{
    class bai2
    {
        static void Main(string[] args)
        {
             
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age:  ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your heigh(cm):  ");
            int heigh = int.Parse(Console.ReadLine());
            double h = Convert.ToDouble(heigh);


            Console.Write("Enter your weight(kg):  ");
            int weight = int.Parse(Console.ReadLine());
            double w = Convert.ToDouble(weight);

            double BMI = w /((h / 100) * (h / 100));

            Console.Write("Enter your email:  ");
            string email = Console.ReadLine();

            Console.Write("In relationship (true/false): ");

            bool check;
            if (Console.ReadLine() == "true")
                check = true;
            else
                check = false;

            Console.WriteLine("----------------out put ---------------");

            Console.WriteLine($"Name: {name} ");
            Console.WriteLine($"Age: {age} ");
            Console.WriteLine($"heght: {heigh} weight {weight}   BMI {Math.Round(BMI,2)} ");
            Console.Write($"In relationship {check}  ");

            
            Console.ReadLine();
        }
    }
}
