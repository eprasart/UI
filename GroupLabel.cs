/*
 * GroupLabel. Just like GroupBox.
*/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kPrasat.UI
{
    [DefaultProperty("Text")]
    public partial class GroupLabel : UserControl
    {
        public GroupLabel()
        {
            InitializeComponent();
            TabStop = false;
        }

        [Browsable(true)]
        public string Text
        {
            get { return lblGroup.Text; }
            set { lblGroup.Text = value; }
        }

        private void GroupLabel_FontChanged(object sender, EventArgs e)
        {
            lblGroup.Font = Font;
        }

        private void GroupLabel_ForeColorChanged(object sender, EventArgs e)
        {
            lblGroup.ForeColor = ForeColor;
        }       
    }
}
