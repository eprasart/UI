using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace kUI
{
    public partial class AddressButton : System.Windows.Forms.Button
    {
        private string[] AddressType = { "Business", "Bill to", "Ship to", "Warehouse", "Home", "Legal", "Postal", "Other" };

        public AddressButton()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(this, 0, this.Height);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

    }
}
