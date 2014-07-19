using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace kBit.UI
{
    public partial class DateTimePicker : System.Windows.Forms.DateTimePicker
    {
        private bool bTab = true;

        public DateTimePicker()
        {
            InitializeComponent();
        }

        public DateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool TabOnEnter
        {
            set { bTab = value; }
            get { return bTab; }
        }

        private void DateTimePicker_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (bTab) Misc.SendTabKey(e);
        }
    }
}
