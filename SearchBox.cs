using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kPrasat.UI
{
    public delegate void SearchHandler(object sender, EventArgs e);

    [DefaultEvent("Search"),
     DefaultProperty("Message")]
    public partial class SearchBox : UserControl
    {
        public event SearchHandler Search;

        public SearchBox()
        {
            InitializeComponent();
        }
        //[Browsable(true)]
        public string Caption
        {
            get
            {
                return txtSearch.Text;
            }
            set
            {
                txtSearch.Text = value;
            }
        }

        public string Message
        {
            get
            {
                return lblMsg.Text;
            }
            set
            {
                lblMsg.Text = value;
            }
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = (txtSearch.Text.Length == 0);
            if (txtSearch.Text.Length == 0)
                Search(sender, e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Search(sender, e);
            }
        }
    }
}
