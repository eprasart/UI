using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace kUI
{
    public partial class TextBox : System.Windows.Forms.TextBox
    {
        private bool bTab = true;
        public bool Numeric { get; set; }
        public string Format { get; set; }

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

        public bool IsEmpty
        {
            get { return Text.Length == 0; }
        }

        public bool IsEmptyTrim
        {
            get { return Text.Trim().Length == 0; }
        }

        private void TextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (bTab) Misc.SendTabKey(e);
            if (!Numeric) return;
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
                decimal d;
                if (factor == 1)
                    d = decimal.Parse(Text);
                else
                {
                    s = Text.Substring(0, Text.Length - 1);
                    d = decimal.Parse(s);
                    d *= factor;
                }
                Text = d.ToString(Format);   //todo: no fraction => NumericFormat property?
            }
            catch { }
        }

        /// <summary>
        /// Move the cursor to the end and focus
        /// </summary>
        public void Focus2()
        {
            SelectionStart = Text.Length;
            Focus();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Numeric) return;
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)

            var c = e.KeyChar;
            var s = c.ToString().ToUpper();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && (s != "T" && s != "K" && s != "M"))
                e.Handled = true;

            // Only allow one letter
            var textUpper = Text.ToUpper();
            if (char.IsLetter(e.KeyChar) && (textUpper.Contains("T") || textUpper.Contains("K") || textUpper.Contains("M")))
                e.Handled = true;

            // only allow one decimal point
            if ((e.KeyChar == '.') && (Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
