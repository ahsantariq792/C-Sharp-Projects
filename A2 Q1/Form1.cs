using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double time = 0.0;
        double distance = 0.0;      
        double speed=0.0;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int limit = this.Width;
            int picbox = pictureBox1.Width;
            time++;
            pictureBox1.Left += 8;
            pictureBox2.Left += 5;
            if (pictureBox1.Left > (limit - picbox))
            {
                timer1.Stop();
                speed = limit / time;
                label1.Text = "Car1(Above) speed: " + Convert.ToString(Math.Round(speed, 2));
                distance = limit - pictureBox2.Location.X;
                speed = (limit - distance) / time;
                label2.Text = "Car2(Below) speed:" + Convert.ToString(Math.Round(speed, 2));
                MessageBox.Show("Car1(Above) wins" + Environment.NewLine + label1.Text + Environment.NewLine + label2.Text);

            }

            else if (pictureBox2.Left > (limit - picbox))
            {
                timer1.Stop();
                speed = limit / time;
                label2.Text = "Car2(Below) speed:" + Convert.ToString(Math.Round(speed, 2));
                distance = limit - pictureBox1.Location.X;
                speed = (limit - distance) / time;
                label1.Text = "Car1(Above) speed:: " + Convert.ToString(Math.Round(speed, 2));
                MessageBox.Show("Car2(Blow) wins" + Environment.NewLine + label1.Text + Environment.NewLine + label2.Text);
            }

        }

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 15;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
    }
}
        
