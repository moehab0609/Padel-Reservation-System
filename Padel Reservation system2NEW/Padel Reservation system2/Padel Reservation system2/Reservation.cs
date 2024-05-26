using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padel_Reservation_system2
{
    public partial class Reservation : Form
    {

        public static Payment pay;
        public static Reservation instance;
        

        public Reservation()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name= "Name";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Columns[2].Name = "Court Number";
            dataGridView1.Columns[3].Name = "Date";
            dataGridView1.Columns[4].Name = "Time Period";




        }

    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ViewReservation viewReservation = new ViewReservation();
            //viewReservation.Show();
            //NewReservation newReser = new NewReservation(textBox1.Text, textBox2.Text, Court1.Items,monthCalendar1.MaxDate);
            addRow(textBox1.Text, textBox2.Text, textBox3.Text, monthCalendar1.SelectionRange.Start, textBox4.Text);
            ViewReservation viewReservation = new ViewReservation();
            //  DataGrid.ReferenceEquals(viewReservation, this);
            //ViewReservation.instance.DataGrid.Rows.Add(dataGridView1.Rows.Cells(0).value);

            // foreach (DataGridViewRow row in dataGridView1.Rows)
            // {
            // if (!row.IsNewRow)
            // {
            //    DataGridViewRow newRow = new DataGridViewRow();
            //newRow.CreateCells(ViewReservation.dataGridView);
            //  for (int i = 0; i < row.Cells.Count; i++)
            //    {
            //          newRow.Cells[i].Value = row.Cells[i].Value;
            //        }
            //          ViewReservation.DataGridView.Rows.Add(newRow);
            //        }
            //      }
            Form1.addrowview(textBox1.Text, textBox2.Text, textBox3.Text, monthCalendar1.SelectionRange.Start, textBox4.Text);
            
           // Form1.v.Show();
        }
      

        private void addRow(string name,string email,string courtNum,DateTime date,string clock)
        {
            string courtnum=Convert.ToString(courtNum);
             string Date = Convert.ToString(date);

            string[] row = { name, email, courtnum, Date ,clock};
            dataGridView1.Rows.Add(row);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Court1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            pay = payment;
            payment.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = new DateTime();   



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
