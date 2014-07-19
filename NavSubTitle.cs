// This control is usually used with Panel

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace kBit.UI
{
    [DefaultProperty("Text")]
    public partial class NavSubTitle : UserControl
    {
        public NavSubTitle()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;  // Set default dock to Top
        }

        //[Browsable(true)]
        public  string Caption
        {
            // Add two spaces to the label so that it look nice
            get { return lblHeader.Text.Substring(2); }
            set { lblHeader.Text = "  " + value; }
        }
    }
}
