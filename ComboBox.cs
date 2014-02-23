using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Kredit.UI
{
    public partial class ComboBox : System.Windows.Forms.ComboBox
    {
        private bool bTab = true;

        public ComboBox()
        {
            InitializeComponent();
        }

        public ComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool TabOnEnter
        {
            set { bTab = value; }
            get { return bTab; }
        }

        public bool Required
        {
            set { this.BackColor = Color.Beige; }
        }

        private void ComboBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (bTab) Misc.SendTabKey(e);
        }

        //TODO: write this one; need ref to Library.dll
        //public void SelectedID
        //{
            //get{
            //      Record Iden = (Record)cbo.SelectedItem;

            //return Iden.ID;
            //}
        //}
    }
}
