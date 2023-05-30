using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NetNthFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input index: ");
            string w_strN = Console.ReadLine();
            int w_nN = 0;
            bool w_bParseRes = int.TryParse(w_strN.Trim(), out w_nN);
            if (w_bParseRes == false)
            {
                Console.WriteLine("Input valid number.");
                // Console.WriteLine("Input exit to terminate.");
                // string w_strTemp = Console.ReadLine();
                // if (w_strTemp == "exit")
                //     Environment.Exit(0);
                Environment.Exit(0);
            }

            int[] w_arrnRet = new int[2];
            FibonacciUtil.fastDoubling(w_nN, w_arrnRet);
            Console.WriteLine($"{w_nN}th of Finobacci series is {w_arrnRet[0]}.");
            Console.ReadLine();
        }
    }
}
