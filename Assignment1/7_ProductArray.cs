using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ProductArray
    {
        private static int[] PrintProduct(int[] array, int size)
        {
            int[] ans = new int[size];
            for(int i = 0; i < size; i++)
            {
                ans[i] = 1;
                for(int j = 0; j < size; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    ans[i] = ans[i] * array[j];
                }
            }

            return ans;
        }
        public static void FindProductArray()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter the element at {0} index : ", i));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe array is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("{0} ", array[i]));
            }
            Console.WriteLine("\n");

            int[] ans = PrintProduct(array, size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("{0} ", ans[i]));
            }

            Console.ReadKey();
        }
    }
}
