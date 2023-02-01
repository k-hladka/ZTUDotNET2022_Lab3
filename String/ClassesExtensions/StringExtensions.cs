using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.ClassesExtensions
{
    public static class StringExtensions
    {
        public static string Invert(this string str)
        {
            string resultString = "";
            for(int i= str.Length-1; i>=0; i--)
                resultString += str[i];
            return resultString;
        }
        public static int CountChar(this string str, char c)
        {
            int count = 0;
            foreach(char i in str)
                if (i == c)
                    count++;
            return count;
        }
    }
}
