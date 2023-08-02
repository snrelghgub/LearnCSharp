using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Models
{
    internal static class Logger
    {
        public static void LogListType<T>(List<T> list)
        {
            Console.WriteLine($"List type: {typeof(T).Name}");
        }

        public static void DebugLog(string message)
        {
            Console.WriteLine($"[DEBUG]: {message}");
        }
    }
}
