using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
   
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Input expression: ");
                double output=Сhanged.Calculate(Console.ReadLine());
               
                    Console.WriteLine(output);
               
            }
        }
    }
}
