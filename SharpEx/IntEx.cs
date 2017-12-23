using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpEx
{
    namespace Extension
    {
        public static class IntEx
        {
            // loop for int
            // (15).@for( () => Console.Write("step") )
            public static void @for(this int source, Action action)
            {
                int len = source;
                for (int i = 0; i < len; i++)
                {
                    action();
                }
            }

            // loop for int with self-arg
            // (3).@for( (n) => Console.Write(n) )  // => 210
            public static void @for(this int source, Action<int> action)
            {
                int len = source;
                for (int i = 0; i < len; i++)
                {
                    action(i);
                }
            }
        }
    }
}
