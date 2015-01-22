using System;
using System.Windows.Forms;

namespace kBit.UI
{
    public partial class DataGridView : System.Windows.Forms.DataGridView
    {
        private long _Id = 0;

        public DataGridView()
        {
            InitializeComponent();
            AutoGenerateColumns = false;
        }

        public long Id
        {
            get { return _Id; }
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

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            long val = 0;
            if (SelectedRows.Count > 0)//&& CurrentRow.Selected == true)
                try
                {
                    val = (long)SelectedRows[0].Cells[0].Value;
                    //val = (long)CurrentRow.Cells[0].Value;
                }
                catch { }   // Error for dgvSchedule since Id is null (when .AddRow())
            _Id = val;
        }
    }
}
