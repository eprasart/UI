using System;
using System.Windows.Forms;

namespace kUI
{
    public partial class Address : UserControl
    {
        private byte nInd = 0;  // Current Item index
        private string[] addresses = new string[8];
        public enum AddressType { Business, Bill_To, Ship_To, Warehouse, Home, Legal, Postal, Other };

        public Address()
        {
            InitializeComponent();
        }

        private void SetAddress(AddressType at, string adr)
        {
            addresses[(int)at] = adr;
        }

        public string GetAddress(AddressType at)
        {
            return addresses[(int)at];
        }

        // Addresses property
        public string[] Addresses
        {
            set
            {
                txtAddress.Text = "";
                addresses = value;
                ShowFirstAvailable();
            }
            get
            {
                txtAddress_Validated(null, null);   // call this in case Validated does not fired; to save address of the active type
                return addresses;
            }
        }

        private void ShowFirstAvailable()
        {
            for (byte i = 0; i < addresses.Length; i++)
            {
                if (addresses[i] != null && addresses[i].Length > 0)
                {
                    txtAddress.Text = addresses[i];
                    btnAddress.Text = mnuAddress.Items[i].Text;
                    nInd = i;
                    return;
                }
            }
        }

        private void btnAddress_MouseDown(object sender, MouseEventArgs e)
        {
            // Mark menu item bold if the address exists
            foreach (ToolStripItem mi in mnuAddress.Items)
            {
                int ind = int.Parse(mi.Tag.ToString());
                System.Drawing.FontStyle fs = System.Drawing.FontStyle.Regular;
                if (addresses[ind] != null && addresses[ind].Length > 0)
                    fs = System.Drawing.FontStyle.Bold;
                mi.Font = new System.Drawing.Font("Segoe UI", 9F, fs, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            mnuAddress.Show(btnAddress, 0, btnAddress.Height);
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            byte indNew;
            ToolStripMenuItem mnu = (ToolStripMenuItem)sender;
            indNew = byte.Parse(mnu.Tag.ToString());
            if (nInd == indNew) return;
            btnAddress.Text = mnu.Text;
            nInd = indNew;
            txtAddress.Text = addresses[nInd];    // get
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            addresses[nInd] = txtAddress.Text;    // save
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
