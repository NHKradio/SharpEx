using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpEx.Support.Forms;

namespace SharpEx
{
    namespace Support
    {
        public static class InputBox
        {
            public static string Show(string title = "", string caption = "", string tbtext = "")
            {
                InputBoxForm f = new InputBoxForm(title, caption, tbtext);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    return InputBoxForm.output;
                }
                return string.Empty;
            }
        }
    }
}
