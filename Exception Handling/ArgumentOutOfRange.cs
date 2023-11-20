using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class ArgumentOutOfRange
    {
        public static void Method()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            Console.WriteLine("Number of items : {0}", list.Count);
            try {
                Console.WriteLine("The fourth item : {0}", list[4]);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
