using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsExercises
{
    class BasicExercises
    {
        static void Main(string[] args)
        {
            //Basic Exercises
            //1.
            Console.WriteLine("Hello");
            Console.WriteLine("Kayti");

            //2.
            Console.WriteLine(2 + 2);

            //3.
            Console.WriteLine(4 / 2);

            //4.
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //5.
            int number1, number2, temp;
            Console.WriteLine("Input the first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After swapping :");
            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number : " + temp);

            //6. 
            Console.WriteLine("Input the first number to multiply:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");
            int number3 = int.Parse(Console.ReadLine());
            int result = number1 * number2 * number3;
            Console.WriteLine("{0} X {1} X {2} = {3}", number1, number2, number3, result);

            //7. 

        }
    }
}
