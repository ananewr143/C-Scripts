using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Assignment1
    {

        int x;
        int y;
        int z;

        
        public void display()
        {
            Console.WriteLine("enter the number x");
            x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number z");
            z = Convert.ToInt32(Console.ReadLine());

            int result = x*y*z;

            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                        x, y, z, result);
        }


        



    }
}
