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
            public static void @for(this int source, Action action)
            {
                int n = source;
                while (n-- > 0)
                {
                    action();
                }
            }
        }
    }
}
