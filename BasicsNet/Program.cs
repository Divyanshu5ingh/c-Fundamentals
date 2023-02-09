using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsNet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered {0}", num);

            Console.WriteLine("Enter a double number");
            double db =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You entered {0}", db);
            Console.ReadKey();
        }
    }
}
