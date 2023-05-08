using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Welcome to Dotnet Tutorials";

            int wordCount = sentence.GetWordCount();

            Console.WriteLine($"Count : {wordCount}");

            Console.ReadKey();

        }

    }

    public static class ExtensionHelper

    {

        public static int GetWordCount(this string str)

        {

            if (!String.IsNullOrEmpty(str))

                return str.Split(' ').Length;

            return 0;

        }
    }
    
}
