using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class Logging
    {
        public enum LogTypes
        {
            Error = 404,
            Warnings = 400,
            Fatal,
            Information = 900     // changing of underlying value
        }

        public void WriteLog(string logMessage, LogTypes logTypes)
        {
            switch (logTypes)
            {
                case LogTypes.Fatal:
                    Console.WriteLine("Write {0}", logMessage);
                    break;

                case LogTypes.Error:
                    Console.WriteLine("Write {0}", logMessage);
                    break;

                case LogTypes.Information:
                    Console.WriteLine("Write {0}", logMessage);
                    break;

                case LogTypes.Warnings:
                    Console.WriteLine("Write {0}", logMessage);
                    break;
            }
        }
    }
    class UseEnums
    {
        public static void Method()
        {
            // under lying value    

            //Console.WriteLine(Convert.ToInt32(Logging.LogTypes.Error));
            //Console.WriteLine(Convert.ToInt32(Logging.LogTypes.Warnings));
            //Console.WriteLine(Convert.ToInt32(Logging.LogTypes.Fatal));
            //Console.WriteLine(Convert.ToInt32(Logging.LogTypes.Information));


            Logging logging = new Logging();
            logging.WriteLog("Error Log", Logging.LogTypes.Error);
            logging.WriteLog("Warning Log", Logging.LogTypes.Warnings);
            logging.WriteLog("Fatal Log", Logging.LogTypes.Fatal);
            logging.WriteLog("Information Log", Logging.LogTypes.Information);
            Console.ReadKey();
        }
    }
}
