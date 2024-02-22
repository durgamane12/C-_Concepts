using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        int number1;
        int number2;
        int result;

        void Add()
        {
            result = number1 + number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Sub()
        {
            result = number1 - number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Mul()
        {
            result = number1 * number2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            cal.number1 = 40;
            cal.number2 = 20;

            cal.Add();
            cal.Sub();
            cal.Mul();

            Calculator cal1 = new Calculator();

            cal1.number1 = 100;
            cal1.number2 = 40;

            cal1.Add();
            cal1.Sub();
            cal1.Mul();

        }


    }
}
