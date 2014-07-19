using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kPrasat.UI
{
    [DefaultProperty("Text")]
    public partial class TextBoxPlaceHolder : UserControl
    {
        [Browsable(true)]
        public event EventHandler TextChanged;

        public TextBoxPlaceHolder()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Browsable(true)]
        public string PlaceHolder
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label1.Visible = (textBox1.Text.Length == 0);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextChanged(sender, e);
        }

        private void TextBoxPlaceHolder_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled == false)
                label1.Visible = false;
            else
                textBox1_Leave(null, null);
        }
    }
}
