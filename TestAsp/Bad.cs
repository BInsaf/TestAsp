using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAsp
{

    public class Bad
    {
        public void M()
        {
            DoPrint("Hello");
            DoPrint(null);
            Logger.Log("Hello, World!");
        }
        void DoPrint(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static class Logger
        {
            [Obsolete("Use Log(LogLevel level, string s) instead")]
            public static void Log(string s)
            {
                // ...
            }

            public static void Log(LogLevel level, string s)
            {
                // ...
            }
        }

        enum LogLevel
        {
            Info,
            Warning,
            Error
        }
    }
    }