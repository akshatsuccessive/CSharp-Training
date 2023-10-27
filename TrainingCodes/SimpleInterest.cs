using System;

namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double principal;
            while (true)
            {
                principal = 0.0;
                Console.Write("Enter the principal amount : ");
                var inputPrincinpal = Console.ReadLine();
                if (double.TryParse(inputPrincinpal, out principal))
                {
                    Console.WriteLine(String.Format("Your Principal Amount is : {0}\n", principal));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Principal Amount, Please try again\n");
                }
            }

            double rateOfInterest;
            while (true)
            {
                rateOfInterest = 0.0;
                Console.Write("Enter the Rate of Interest : ");
                var inputRateOfInterest = Console.ReadLine();
                if (double.TryParse(inputRateOfInterest, out rateOfInterest))
                {
                    Console.WriteLine(String.Format("Your Rate of Interest is : {0}\n", rateOfInterest));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Rate of Interset, Please try again\n");
                }
            }


            double time;
            while (true)
            {
                time = 0.0;
                Console.Write("Enter the time in years : ");
                var inputTime = Console.ReadLine();
                if (double.TryParse(inputTime, out time))
                {
                    Console.WriteLine(String.Format("Your Time in years : {0}\n", time));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Time, Please try again\n");
                }
            }

            double simpleInterest = (principal * rateOfInterest * time) / 100;
            Console.WriteLine(String.Format("\nThe simple Interest is : {0}", simpleInterest));
            Console.WriteLine(String.Format("Your total amount is : {0} ", principal + simpleInterest));

            Console.ReadKey();
        }
    }
}

