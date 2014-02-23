using System;

namespace Kredit.UI
{
    public partial class Line : System.Windows.Forms.Label
    {
        public Line()
        {
            InitializeComponent();
            Text = "";
            AutoSize = false;
        }

        private void Line_Resize(object sender, EventArgs e)
        {
            //if (this.Height != 2)
            //    this.Height = 2;
        }

        private void Line_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
