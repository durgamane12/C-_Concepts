using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        int num1;
        int num2;
        int result;

        void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Sub()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        void Mul()
        {
            result = num1 * num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void Main(string[] args)
        {
            Calculator cal = new Calculator();

            cal.num1 = 40;
            cal.num2 = 20;

            cal.Add();
            cal.Sub();
            cal.Mul();

            Calculator cal1 = new Calculator();

            cal1.num1 = 100;
            cal1.num2 = 40;

            cal1.Add();
            cal1.Sub();
            cal1.Mul();

        }


    }
}
