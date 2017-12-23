using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SharpEx
{
    namespace Extension
    {
        public static class StringEx
        {
            // reverse letters register
            // a => A   B => b
            public static string Downcase(this string source)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < source.Length; i++)
                {
                    if (char.IsLetter(source[i]))
                    {
                        if (char.IsLower(source[i]))
                        {
                            sb.Append(char.ToUpper(source[i]));
                        }
                        else
                        {
                            sb.Append(char.ToLower(source[i]));
                        }
                    } else
                    {
                        sb.Append(source[i]);
                    }
                }
                return sb.ToString();
            }

            // loop for string with self-arg
            // "hello".@foreach( (n) => Console.Write(n + ' ') )  // => h e l l o
            public static void @foreach(this string source, Action<char> action)
            {
                int len = source.Length;
                for (int i = 0; i < len; i++)
                {
                    action(source[i]);
                }
            }

            public static string Shuffle(this string source)
            {
                int len = source.Length;
                char[] output = source.ToArray();
                Random rnd = new Random();
                for (int i = 0; i < len; i++)
                {
                    int r = rnd.Next(0, i + 1);
                    output[i] = output[r];
                    output[r] = source[i];
                }
                return new string(output);
            }

            // return all match values from regex pattern
            // "hello world".FromRegex("(\w*)") => ["hello", "world"]
            public static string[] FromRegex(this string source, string pattern)
            {
                List<string> arr = new List<string>();
                var ms = Regex.Matches(source, pattern);
                foreach (Match m in ms)
                {
                    for (int i = 1; i < m.Length; i++)
                    {
                        arr.Add(m.Groups[i].Value);
                    }
                }
                return arr.ToArray();
            }
        }
    }
}
