using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kBit.UI
{
    public partial class NumericUpDown : System.Windows.Forms.NumericUpDown
    {
        public bool TabOnEnter { get; set; }

        public NumericUpDown()
        {
            InitializeComponent();
        }

        public NumericUpDown(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void NumericUpDown_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (TabOnEnter) Misc.SendTabKey(e);
        }
    }
}
