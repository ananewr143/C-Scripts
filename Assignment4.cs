using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Assignment4
    {

        public void display()
        {
            int x;
            int y;

            Console.Write("Enter the First number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y < 0)
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
