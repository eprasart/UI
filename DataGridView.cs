using System;
using System.Windows.Forms;

namespace kPrasat.UI
{
    public partial class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataGridView()
        {
            InitializeComponent();
            AutoGenerateColumns = false;
        }

        public long Id
        {
            get
            {
                long val = 0;
                if (CurrentRow != null && CurrentRow.Selected == true)
                    val = (long)CurrentRow.Cells[0].Value;
                return val;
            }
        }

        public void ShowLessColumns(bool b = false)
        {           
            if (b)  // Show 2 columns
            {
                Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                for (int i = 3; i < ColumnCount; i++)   // Skip Id
                {
                    //int counter = 0;
                    //string pName = Columns[i].Name.ToUpper();
                    //Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //if (pName != Column1.ToUpper() && pName != Column2.ToUpper())
                    //{
                        Columns[i].Visible = false;
                        //counter++;
                        //if (counter == 2) return;
                    //}
                }
            }
            else
            {
                for (int i = 1; i < ColumnCount; i++)
                    Columns[i].Visible = true;
                Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
