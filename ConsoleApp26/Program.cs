using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public class Program
    {
        public static void Main()
        {

            Complex complexNum1 = new Complex(1, 2);
            Complex complexNum2 = new Complex(2, 4);

            Console.WriteLine("first complex number is: {0}", complexNum1);
            Console.WriteLine("second complex number is: {0}", complexNum2);

            Console.WriteLine("complexNum1 == complexNum2: {0}", complexNum1 == complexNum2);
            Console.WriteLine("complexNum1 != complexNum2: {0}", complexNum1 != complexNum2);
            Console.WriteLine("complexNum1 + complexNum2 = {0}", complexNum1 + complexNum2);
            Console.WriteLine("complexNum1 - complexNum2 = {0}", complexNum1 - complexNum2);
            Console.WriteLine("complexNum1 * complexNum2 = {0}", complexNum1 * complexNum2);
            Console.WriteLine("complexNum1 / complexNum2 = {0}", complexNum1 / complexNum2);

            Console.ReadLine();
        }
    }
}

