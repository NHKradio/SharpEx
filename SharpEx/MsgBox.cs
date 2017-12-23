using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEx
{
    namespace Support {
        public static class MsgBox
        {
            // fast show
            public static DialogResult Show()
            {
                return MessageBox.Show(string.Empty);
            }

            // universal show
            public static DialogResult Show(params object[] objects)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in objects)
                {
                    sb.Append(item);
                }
                return MessageBox.Show(sb.ToString());
            }
        }
    }
}
