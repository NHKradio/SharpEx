using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpEx
{
    namespace Support
    {
        namespace Forms
        {
            public partial class InputBoxForm : Form
            {
                public static string output;

                public InputBoxForm(string title = "", string caption = "", string tbtext = "")
                {
                    InitializeComponent();
                    output = string.Empty;
                    Text = title;
                    label1.Text = caption;
                    textBox1.Text = tbtext;
                    button1.Click += Button1_Click;
                    button1.DialogResult = DialogResult.OK;
                }

                private void Button1_Click(object sender, EventArgs e)
                {
                    output = textBox1.Text;
                }
            }
        }
    }
}
