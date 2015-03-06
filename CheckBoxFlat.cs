/*
 * Menu Item (at POS)
 * Flat check box
*/

using System;
using System.Windows.Forms;

namespace kUI
{
    public partial class CheckBoxFlat : CheckBox    // todo: change name; cuz Table on POS use this control too
    {
        public int ID { get; set; }

        public CheckBoxFlat()
        {
            InitializeComponent();
        }       
    }
}
