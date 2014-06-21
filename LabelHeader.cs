// This control is usually used with Panel

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace kPrasat.UI
{
    [DefaultProperty("Text")]
    public partial class LabelHeader : UserControl
    {
        public LabelHeader()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;  // Set default dock to Top
        }

        public string Caption
        {
            // Add two spaces to the label so that it look nice
            get { return lblHeader.Text.Substring(2); }
            set { lblHeader.Text = "  " + value; }
        }
    }
}
