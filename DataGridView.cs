using System;
using System.Windows.Forms;

namespace Kredit.UI
{
    public partial class DataGridView : System.Windows.Forms.DataGridView
    {
        public int Id = 0;

        public DataGridView()
        {
            InitializeComponent();
            AutoGenerateColumns = false;
        }

        public string Column1 { get; set; }
        public string Column2 { get; set; }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Id = (int)CurrentRow.Cells[0].Value;
            }
            catch
            {
                Id = 0;
            }
        }

        public void ShowLessColumns(bool b = false)
        {
            if (b)  // Show 2 columns
            {
                for (int i = 1; i < ColumnCount; i++)   // Skip Id
                {
                    int counter = 0;
                    string pName = Columns[i].Name.ToUpper();
                    Columns[Column2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (pName != Column1.ToUpper() && pName != Column2.ToUpper())
                    {
                        Columns[i].Visible = false;
                        counter++;
                        if (counter == 2) return;
                    }
                }
            }
            else
            {
                for (int i = 1; i < ColumnCount; i++)
                    Columns[i].Visible = true;
                Columns[Column2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
