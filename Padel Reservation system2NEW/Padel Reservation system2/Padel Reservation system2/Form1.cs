using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Padel_Reservation_system2
{
    public partial class Form1 : Form
       
    {
        public static ViewReservation v;
        public Form1()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
           
           Form1.v.Show();

        }

      

        public void button1_Click(object sender, EventArgs e)
        {
            ViewReservation viewReservation = new ViewReservation();
            v = viewReservation;
            Reservation reservation=new Reservation();
            reservation.Show();
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        public static void addrowview(string name, string email, string courtNum, DateTime date, string clock)
        {
            v.addRow(name,email,courtNum,date,clock);

        }
    }
}
