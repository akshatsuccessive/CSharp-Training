using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class MultipleCatch
    {
        public static void Method()
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {
                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }


            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            //Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}", arr[i]);
                }
            }
        }
    }
}
