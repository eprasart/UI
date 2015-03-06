using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace kUI
{
    public partial class Bill : ButtonFlat
    {
        private decimal mAmount;
        public bool DecimalPoint { get; set; }

        public Bill()
        {
            InitializeComponent();
        }

        public decimal Amount
        {
            set
            {
                mAmount = value;                
                string s = "$";
                if (DecimalPoint)
                    s += mAmount.ToString("N02");
                else
                    s += mAmount.ToString();
                Text = s;
            }
            get { return mAmount; }
        }
    }
}
