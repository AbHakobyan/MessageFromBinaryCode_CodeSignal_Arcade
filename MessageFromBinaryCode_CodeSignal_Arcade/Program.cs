using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFromBinaryCode_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "010010000110010101101100011011000110111100100001";
            string x = messageFromBinaryCode(s);
            Console.WriteLine(x);
        }

        static string messageFromBinaryCode(string code)
        {
            var stringArray = Enumerable.Range(0, code.Length / 8).Select(i => Convert.ToByte(code.Substring(i * 8, 8), 2)).ToArray();
            var str = Encoding.UTF8.GetString(stringArray);
            return str;
        }
    }
}
