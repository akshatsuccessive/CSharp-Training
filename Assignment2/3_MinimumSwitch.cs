using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MinimumSwitches
    {
        private static int CountMinSwitches(int[] bulb, int size)
        {
            // O(n2) Solution
            /*
            int count = 0;
            for(int i = 0; i < size; i++)
            {
                if(bulb[i] == 1)
                {
                    continue;
                }
                else
                {
                    bulb[i] = 1;
                    count++;
                    for(int j = i + 1; j < size; j++)
                    {
                        bulb[j] = ~(bulb[j]);
                    }
                }
            }
            return count;
            */

            // O(n) solution
            int switchCount = 0;
            for (int i = 0; i < size; i++)
            {
                int currentState = bulb[i];
                if (switchCount % 2 == 1)
                {
                    currentState = bulb[i] == 0 ? 1 : 0;
                }
                if (currentState == 0)
                {
                    switchCount++;
                }
            }
            return switchCount;
        }
        public static void CountMinimumSwitches()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] bulb = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter the element at {0} index : ", i));
                bulb[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe array is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("{0} ", bulb[i]));
            }

            int count = CountMinSwitches(bulb, size);
            Console.WriteLine(String.Format("\nThe Minimum Number of Switches are : {0}", count));

            Console.ReadKey();
        }
    }
}
