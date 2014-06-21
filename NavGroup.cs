using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace kPrasat.UI
{
    [DefaultProperty("Text"), DefaultEvent("GroupClick")]
    public partial class NavGroup : UserControl
    {
        private bool bSelected = false;

        public delegate void ClickHandler(object sender, EventArgs e);

        public event ClickHandler GroupClick;

        public NavGroup()
        {
            InitializeComponent();
        }

        public bool Selected
        {
            get { return bSelected; }
            set
            {
                bSelected = value;
                if (!bSelected)
                {
                   pictureBox1.SuspendLayout();
                    this.BackgroundImage = Properties.Resources.Group;  // set to normal for deselect group
                    Application.DoEvents();
                    pictureBox1.ResumeLayout();
                }
                else
                    this.BackgroundImage = Properties.Resources.GroupSelected;

            }
        }
        //[Browsable(true)]
        public string Caption
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public Image Picture
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private void Group_MouseEnter(object sender, EventArgs e)
        {
            if (!Selected)
                this.BackgroundImage = Properties.Resources.GroupOver;
            else
                this.BackgroundImage = Properties.Resources.GroupSelectedOver;

        }

        private void Group_MouseLeave(object sender, EventArgs e)
        {
            if (!Selected)
                this.BackgroundImage = Properties.Resources.Group;
            else
                this.BackgroundImage = Properties.Resources.GroupSelected;
            //todo: should create a private void that handle to change the bg img
        }

        private void Group_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.GroupDown;
        }

        private void Group_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.GroupSelected;
            Application.DoEvents(); // Force picture to change immediately
            GroupClick(this, e);
            Selected = true;
        }
    }
}
