using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace kBit.UI
{
    public partial class TextBox : System.Windows.Forms.TextBox
    {
        private bool bTab = true;
        public bool Numeric { get; set; }

        public TextBox()
        {
            InitializeComponent();
        }

        public TextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public bool TabOnEnter
        {
            set { bTab = value; }
            get { return bTab; }
        }

        private void TextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (bTab) Misc.SendTabKey(e);
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (!Numeric) return;
            var s = Text;
            if (s.Length == 0) return;
            s = s.Substring(s.Length - 1).ToUpper();
            int factor = 1;
            switch (s)
            {
                case "K":
                case "T":
                    factor = 1000;
                    break;
                case "M":
                    factor = 1000000;
                    break;
            }
            try
            {
                double d;
                if (factor == 1)
                    d = double.Parse(Text);
                else
                {
                    s = Text.Substring(0, Text.Length - 1);
                    d = double.Parse(s);
                    d *= factor;
                }
                Text = d.ToString("#,0");   //todo: no fraction
            }
            catch { }
        }
    }
}
