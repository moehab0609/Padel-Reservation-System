using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Padel_Reservation_system2
{
    public partial class ViewReservation : Form
    {
        public static ViewReservation instance;
        public DataGridView DataGrid;
        public ViewReservation()
        {
            InitializeComponent();

            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Email";
            dataGridView2.Columns[2].Name = "Court Number";
            dataGridView2.Columns[3].Name = "Date";
            dataGridView2.Columns[4].Name = "Time Period";

            DataGrid = dataGridView2;
        }

        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        public void addRow(string name, string email, string courtNum, DateTime date, string clock)
        {
            string courtnum = Convert.ToString(courtNum);
            string Date = Convert.ToString(date);

            string[] row = { name, email, courtnum, Date, clock };
            dataGridView2.Rows.Add(row);
        }
    }
}
