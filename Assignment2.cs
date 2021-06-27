using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Assignment2
    {


        int x;
        int y;
       


        public void display()
        {
            Console.WriteLine("enter the number x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number y");
            y = Convert.ToInt32(Console.ReadLine());
           
            int add = x + y;
            int sub = x - y;
            int mul = x*y;
            int div = x / y;
            Console.WriteLine("Output: {0} + {1} ={2}",
                       x, y, add);
            Console.WriteLine("Output: {0} - {1} ={2}",
                       x, y, sub);
            Console.WriteLine("Output: {0} * {1} ={2}",
                       x, y, mul);
            Console.WriteLine("Output: {0} / {1} ={2}",
                       x, y, div);

        }
    }
}
