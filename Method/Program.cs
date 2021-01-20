using System;
using System.Linq;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add(); //methodu çağırdık
            //Add();
            //Add();

            ////var result= Add2(5,8);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(2,6, 5));
            Console.WriteLine(Add4(5, 9, 7, 8, 5));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("added!");

        }
        static int Add2(int number1,int number2)
        {
            var result = number1 + number2;
            return result;
            
            
        }
        static int Add3(out int number1 ,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2;
        }
        static int Add4 (params int[]numbers)
        {
            return numbers.Sum();
        }
    }
}
