// This control is usually used with Panel

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace kBit.UI
{
    [DefaultProperty("Caption")]
    public partial class NavTitle : UserControl
    {
        public NavTitle()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;  // Set default dock to Top
        }
        
        public  string Caption
        {
            // Add two spaces to the label so that it look nice
            get { return lblHeader.Text.Substring(2); }
            set { lblHeader.Text = "  " + value; }
        }
    }
}
