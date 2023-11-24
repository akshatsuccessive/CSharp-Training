using System;
using System.Threading.Tasks;

namespace Async_Await
{
    class Async_await
    {
        private static async Task Method1()
        {
            await Task.Run(() => {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1 is running");
                    Task.Delay(100).Wait();
                }
            });
        }
        private static void Method2()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2 is running");
                Task.Delay(100).Wait(); 
            }
        }
        public static void Main(string[] args)
        {
            Method1();
            Method2();
        }
    }
}

/*In this code both Method1() and Method2() are independent of each other, when Method1() is called then it waits for 100ms therefore in the meantime Method2() is starting executing. So both methods are executed simultaneously.*/
