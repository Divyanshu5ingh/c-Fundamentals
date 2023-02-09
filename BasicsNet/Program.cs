using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsNet
{
    class Program
    {
        public static int overload(int a, int b)
        {
            return a + b;
        }
        public static int overload(int a, int b, int c)
        {
            return a + b + c;
        }
        
       
        public static void Main(string[] args)
        {
            Console.WriteLine(overload(5, 6));
            Console.WriteLine(overload(1, 2, 3));
           
            
            Console.ReadKey();
        }
    }
}
