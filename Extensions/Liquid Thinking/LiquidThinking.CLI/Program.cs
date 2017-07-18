using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiquidThinking.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = String.Join(" ", args);
            Console.Write(arguments);
        } 
    }
}
