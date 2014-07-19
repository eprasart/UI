using System;
using System.Drawing;

namespace kBit.UI
{
    /// <summary>
    /// Table on POS
    /// </summary>
    public partial class Table : ButtonFlat
    {
        private bool mSelected;
        private TableStatus mStatus;


        public Table()
        {
            InitializeComponent();
            //Status = TableStatus.Vacant;
        }

        private void SetBackColor()
        {
            Color col = Color.CornflowerBlue;   // Normal
         
            if (mSelected)
            {
                col = Color.SteelBlue;
            }
            else
            {
                switch (mStatus)
                {
                    //case TableStatus.Vacant:
                    //break;
                    case TableStatus.Reserved:
                        col = Color.LightYellow;
                        break;
                    case TableStatus.Occupied:
                        col = Color.IndianRed;
                        break;
                }
            }
            BackColor = col;
        }

        public TableStatus Status
        {
            set
            {
                mStatus = value;
                SetBackColor();
            }
            get { return mStatus; }
        }

        public bool Selected
        {
            set
            {                
                mSelected = value;
                SetBackColor();   
            }
            get
            {
                return mSelected;
            }
        }

        //todo: reserved
    }




    public enum TableStatus
    {
        Vacant,
        Reserved,
        Occupied
    }
}
