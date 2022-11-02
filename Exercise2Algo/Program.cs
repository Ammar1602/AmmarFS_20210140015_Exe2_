using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2Algo
{
   class Program
    {

        //array of integers to hold values
        private int[] ammar = new int[35];
        private int camp_count = 0;
        private int mov_count = 0;

        //number of elemebt in array 
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("enter the of element in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 35)
                    break;
                else
                    Console.WriteLine("\narray can have maximum 30 elements \n");
            }
            Console.WriteLine("\n------------------");
            Console.WriteLine("enter array elements");
            Console.WriteLine("\n------------------");
        }
        static void Main(string[] args)
        {
        }
    }
}
