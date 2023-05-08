using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahila", "rose", "lotus" };
            var fQuery =
               from flower in flowers
               let len=flower.Length
               where len>5 && len<7
                where (flower.StartsWith("l"))
                select flower;
            foreach (var flower in fQuery) 
            {
                Console.WriteLine(flower);
            }
        }
    }
}
