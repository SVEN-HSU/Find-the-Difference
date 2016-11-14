//https://leetcode.com/problems/find-the-difference/
//Accepted, low performance :<
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ae";
            string t = "aea";

            
            Console.WriteLine("a ^ b = " + (Convert.ToInt32('a') ^ Convert.ToInt32('b')));
            Console.WriteLine("a ^ a = " + (Convert.ToInt32('a') ^ Convert.ToInt32('a')));
            Console.WriteLine("FindTheDifference(" + s + "," + t + ")=" + FindTheDifference(s, t));
            Console.Read();
        }

        static char FindTheDifference(string s, string t)
        {
            char[] _s = s.ToArray().OrderBy(x => x).ToArray();
            char[] _t = t.ToArray().OrderBy(x => x).ToArray();

            for (int i = 0; i < _s.Length; i++ )
            {
                if ((Convert.ToInt32(_s[i]) ^ Convert.ToInt32(_t[i])) != 0)
                {
                    return _t[i];
                }
            }

            return _t[_t.Length - 1];
        }
    }
}
