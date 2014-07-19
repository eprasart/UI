using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace kBit.UI
{
    public partial class TextBox : System.Windows.Forms.TextBox
    {
        private bool bTab = true;

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

    }
}
