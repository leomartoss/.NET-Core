
using System;
using System.IO;
using System.Globalization;

namespace StringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);                                    
        }
    }
}