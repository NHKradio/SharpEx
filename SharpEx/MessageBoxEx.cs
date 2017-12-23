using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEx
{
    namespace Extension
    {
        public static class MessageBoxEx
        {
            // fast show
            public static DialogResult Show(this MessageBox mbox)
            {
                return MessageBox.Show(string.Empty);
            }

            // univrsal show
            public static DialogResult Show(this MessageBox mbox, params object[] objects)
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
