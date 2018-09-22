using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int wynik=0;
            wynik++;
            wynik = Convert.ToInt32(label2.Text)+wynik;
            label2.Text = Convert.ToString(wynik);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int X, Y;
            Random los = new Random();
            X = los.Next(1000);
            Y = los.Next(1000);

            pictureBox1.Location = new Point(X, Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int x = 0;
            x++;
            x = Convert.ToInt32(label4.Text) + x;
            label4.Text = Convert.ToString(x);
            if(x>=5)
            {
                MessageBox.Show("Przegrałeś!");
                this.Close();
            }
        }
    }
}
