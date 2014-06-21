using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kPrasat.UI
{
    //public delegate void BrowseHandler(object sender, EventArgs e);

    //[DefaultEvent("Browse"),
    //DefaultProperty("Name")]
    public partial class BrowseBox : UserControl
    {
    //    public event BrowseHandler Browse;
    //    private Record rec=new Record(0,"<None>");

    //    public List<Record> record
    //    {
    //        get { return rec; }
    //        set { rec = value; Caption = rec.Description; }
    //    }


    //    [Browsable(true)]
    //    public string Caption
    //    {
    //        set
    //        {
    //            txtDescription.Text = value;
    //        }
    //    }

        public BrowseBox()
        {
            InitializeComponent();
        }

    //    private void btnBrowse_Click(object sender, EventArgs e)
    //    {
    //        Browse(sender, e);
    //    }

    //    private void txtDescription_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        if (e.KeyCode == Keys.Enter)
    //            Browse(sender, e);
    //    }

    //    private void btnRemove_Click(object sender, EventArgs e)
    //    {
    //        record = new Record(0, "<None>");
    //    }
    }
}
