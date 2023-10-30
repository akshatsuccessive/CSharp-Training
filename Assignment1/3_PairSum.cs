using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PairSum
    {
        private static List<Tuple<int, int>> PrintPairs(int[] array, int size, int target)
        {
            var ans = new List<Tuple<int, int>>();
            Console.WriteLine("\nPairs at indices having sum less then {0}", target);
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] + array[j] < target)
                    {
                        // Console.WriteLine(String.Format("{0}, {1}", i, j));
                        var pair = new Tuple<int, int>(i, j);
                        ans.Add(pair);
                    }
                }
            }
            return ans;
        }
        public static void FindPairs()
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

            int target;
            Console.Write("\n\nEnter a target value : ");
            target = Convert.ToInt32(Console.ReadLine());

            var ans = PrintPairs(array, size, target);
            foreach(var item in ans)
            {
                Console.WriteLine(String.Format("{0}, {1}", item.Item1, item.Item2));
            }

            Console.ReadKey();
        }
    }
}
