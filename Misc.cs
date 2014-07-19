using System;
using System.Windows.Forms;

namespace kBit.UI
{
    class Misc
    {
        public static void SendTabKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
