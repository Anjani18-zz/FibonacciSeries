using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonocci_loop
{
    class Program
    {
      static void Main(string[] args)
        {
            int length;
            int firstnum= 0,secondnum= 1, thirdnum= 0;
            try
            {
                Console.WriteLine("Enter the length limit");
                length = int.Parse(Console.ReadLine());
                Console.Write("0 1 ");
                for (int i = 2; i < length; i++)
                {
                    thirdnum = firstnum + secondnum;
                    Console.Write(" " + thirdnum);
                    firstnum = secondnum;
                    secondnum = thirdnum;
                }
            }
            catch(Exception)
            {
                Console.Write("Invalid");
            }
            Console.ReadKey();
        }
          }
}
 