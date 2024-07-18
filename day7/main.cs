using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTi.day7
{
    internal class main
    {
        public static void Main()
        {
            var cal = new Calculator<double>(
            (x, y) => x + y,
            (x, y) => x - y,
            (x, y) => x * y,
            (x, y) => x / y
        );
            double a, b;
            int choose;
            do
            {

                Console.WriteLine("1- Add");
                Console.WriteLine("2- Subtract");
                Console.WriteLine("3- Multiply");
                Console.WriteLine("4- Divide");
                Console.WriteLine("0- exist ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1: // Add
                        Console.Write("Enter First value : ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter Secound value : \n");
                        b = double.Parse(Console.ReadLine());

                        Console.WriteLine($"Add: {cal.PerformAddition(a, b)}");
                        Console.WriteLine("------------------------------------------");
                        break;
                    case 2: // Sub

                        Console.Write("Enter First value : ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter Secound value : \n");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Subtract: {cal.PerformSubtraction(a, b)}");
                        Console.WriteLine("------------------------------------------");



                        break;
                    case 3: // Multi
                        Console.Write("Enter First value : ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter Secound value : \n");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Multiply: {cal.PerformMultiplication(a, b)}");
                        Console.WriteLine("------------------------------------------");


                        break;

                    case 4: //divide
                        Console.Write("Enter First value : ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter Secound value : \n");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Divide: {cal.PerformDivision(a, b)}");
                        Console.WriteLine("------------------------------------------");

                        break;
                }
            } while (choose != 0);
        }


    }
}
