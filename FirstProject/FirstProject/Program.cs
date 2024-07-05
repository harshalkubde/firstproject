using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject//project name
{
    internal class Program //class name  
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("hello world ");

              Console.WriteLine("harshal");
              Console.ReadKey();*/

            Console.WriteLine("welcome to iacsd");
            Console.WriteLine("please enter name-");
            try
            {
                String name = Console.ReadLine();
                Console.WriteLine("please enter your age ");
                int age = int.Parse(Console.ReadLine());
                if (age < 80)
                {
                    Console.WriteLine($"{name}! your ride is ready! Enjoy");
                }
                else
                {
                    Console.WriteLine($"{name}! soory you can not do this activity");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           Console.ReadLine();

        }
    }
}
