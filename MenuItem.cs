using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kredit.UI
{
    public partial class MenuItem : CheckBoxFlat
    {
        public MenuItem()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (!this.Checked) this.Checked = true;
        }
    }
}
