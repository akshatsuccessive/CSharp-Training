using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class NullReference
    {
        public static void Method()
        {
            string name = null;
            try
            {
                Console.WriteLine(name[1]);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Message : {0}", e.Message);
            }
        }
    }
}
