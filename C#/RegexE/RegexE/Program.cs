using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);
            string text = "Hi there, my number is 12314";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n{1}",matches.Count,text);

            foreach (Match match in matches)
            {
                Console.WriteLine("Match: {0} at position {1}", match.Value, match.Index);
            }

            Console.ReadKey();
        }
    }
}
