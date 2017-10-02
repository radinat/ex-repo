using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DiffIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long num = long.Parse(input);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{input} can not fit in any type.");
            }
        }
    }
}
