/*
 * GroupLabel. Just like GroupBox.
*/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kBit.UI
{
    [DefaultProperty("Caption")]
    public partial class GroupLabel : UserControl
    {
        public GroupLabel()
        {
            InitializeComponent();
            TabStop = false;
        }

        [Browsable(true)]
        public string Caption
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
