// Default size: 16 x 16.

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kBit.UI
{
    [DefaultProperty("Caption"), DefaultEvent("ItemClick")]
    public partial class NavItem : UserControl
    {
        public delegate void ClickHandler(object sender, EventArgs e);
        public event ClickHandler ItemClick;

        public NavItem()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        }

        public Image Picture
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        [Browsable(true)]
        public string Caption
        {
            get
            {
                return linkLabel1.Text;
            }
            set
            {
                linkLabel1.Text = value;
            }
        }

        private void NavItem_Click(object sender, EventArgs e)
        {
            ItemClick(this, e);
        }
    }
}