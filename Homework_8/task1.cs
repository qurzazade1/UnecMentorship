using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class task1
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Please, enter the first number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the second number:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the third number:");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First answer is " + (x + y) * z);
            Console.WriteLine("Second answer is " + (x * y + y * z));
            Console.ReadLine();

        }
    }
}
