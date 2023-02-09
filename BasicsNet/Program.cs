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
            int[] a = new int[5];

            for(int i = 0; i< a.Length;i++)
            {
                Console.WriteLine("Enter {0} array", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                Array.Sort(a);
                Console.WriteLine(a[i]);
            }



            Console.ReadKey();
        }
    }
}
