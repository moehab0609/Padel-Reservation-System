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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            Done_payment done = new Done_payment();
            Reservation.pay.Close();
            done.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ( textBox1.Text=="200" || textBox1.Text == "400" || textBox1.Text == "600" || textBox1.Text == "800")
            {
                pay.Show();
            }
            else
            {
                pay.Hide();
            }
           
            
        }
    }
}
