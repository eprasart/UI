using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace kBit.UI
{
    public partial class Number : ButtonFlat
    {
        private int mValue;

        public Number()
        {
            InitializeComponent();
        }

        public int Value
        {
            set
            {
                mValue = value;
                Text = mValue.ToString();
            }
            get { return mValue; }
        }
    }
}
