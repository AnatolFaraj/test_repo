using System;
using System.Collections.Generic;

namespace VsGitCourse
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(Multiply(10, 20));

            

        }

        public static string Multiply<T>(T a, T b)
        {
            return $"a = {a}\tb = {b}";
        }
    }
}
