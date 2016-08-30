using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliza.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ElizaMain eliza = new ElizaMain();

            while(true)
            {
                var input = System.Console.ReadLine();
                var output = eliza.ProcessInput(input);
                System.Console.WriteLine(output);
            }
        }
    }
}
