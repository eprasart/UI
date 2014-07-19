using System;
using System.Drawing;
using System.Windows.Forms;

namespace kBit.UI
{
    //todo: name?? menuitem also use this control
    public partial class ButtonFlatMove : ButtonFlat
    {                
        // Movable table
        private bool bMove = false;
        private Point begin;
        private int x_offset, y_offset;

        public ButtonFlatMove()
        {
            InitializeComponent();
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            int x;
            int y;
            if (e.Button == MouseButtons.Left)
            {
                Point pt;
                pt = e.Location;
                x_offset = e.X;
                y_offset = e.Y;
                x = x_offset;
                y = y_offset;
                pt = new Point(x, y);
                begin = pt;
            }
            Control c = (Control)sender;
            bMove = true;
        }

        private void Table_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = (Control)sender;
            if (bMove && e.Button == MouseButtons.Left)
            {
                Point pt = e.Location;
                int x = e.X - x_offset;
                int y = e.Y - y_offset;
                if (Cursor != Cursors.SizeNWSE)  // Resize                  
                    c.Location = new Point(c.Location.X + x, c.Location.Y + y);
                else
                {
                    c.Size = new Size(c.Width + x, c.Height + y);
                    x_offset = c.Width;
                    y_offset = c.Height;
                }

            }
            else if (e.X >= c.Width - 3 && e.Y >= c.Height - 3) // todo: when resize -> off by 1 or 2; need to fix?
            {
                Cursor = Cursors.SizeNWSE;
            }
            else
                Cursor = Cursors.SizeAll;
        }

        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            bMove = false;
        }

        void btnTable_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
