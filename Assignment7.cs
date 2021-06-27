using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Assignment7
    {
        public void display()
        {
            string x;
            Console.WriteLine("enter the number x");
            x = Convert.ToString(Console.ReadLine());


            if (x.StartsWith("Hello"))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }
        }

    }
}
