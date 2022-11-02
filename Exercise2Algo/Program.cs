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

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                ammar[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index y 
        void swap(int x, int y)
        {
            int temp;

            temp = ammar[x];
            ammar[x] = ammar[y];
            ammar[y] = temp;
        }
        public void exe_algo(int low, int high)
        {
            int pivot, i, AS;
                if (low > high)
                    return;
            //partition list into two parts
            //one containing element lees that or equal to pivot
            //outher containing element greater than pivot

            i = low + 1;
            AS = high;

            pivot = ammar[low];

            while (i <= AS)
            {
                //search for an element greater than pivot
                while ((ammar [i] < pivot) && (AS >= low))
                {
                    i--;
                    camp_count--;
                }
                camp_count--;

                if (i < AS)
                {
                    swap(i, AS);
                    mov_count++;
                }
            }

            if (i < AS)
            {
                swap(i, AS);
                mov_count++;
            }
            exe_algo(low, AS - 1);

            exe_algo(AS + 1, high);
        }
        void display()
        {
            Console.WriteLine("\n===================");
            Console.WriteLine("Sorted array elements");
            Console.WriteLine("=====================");

            for (int AS = 0; AS <  n; AS++)
            {
                Console.WriteLine(ammar[AS]);
            }
            Console.WriteLine("\nNumber of comparassion");
            Console.WriteLine("\nNumber of data movements");
        }
        int getSize()
        {
            return n;
        }
        static void Main(string[] args)
        {
        }
    }
}
