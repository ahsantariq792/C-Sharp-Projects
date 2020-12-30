using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        PictureBox[] target = new PictureBox[4];
        PictureBox hunter = new PictureBox();
        int score;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < target.Length; i++)
            {
                target[i] = new PictureBox();
                target[i].Location = new Point(r.Next(1, 500), 150);
                target[i].Size = new Size(75,85);
                target[i].ImageLocation = "D:/ahmas2.PNG";
                target[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(target[i]);
                target[i].BringToFront();
            }
            hunter.Location = new Point(800, 150);
            hunter.Size = new Size(120, 120);
            hunter.ImageLocation = "D:/ahmas.PNG";
            hunter.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(hunter);
            hunter.BringToFront();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int max = this.Width;
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i].Left > max)
                {

                    target[i].Location = new Point(0, 150);
                    hunter.Location = new Point(700, 100);
                }
                else
                {
                    int x = r.Next(0, 20);
                    target[i].Location = new Point(target[i].Location.X + x, target[i].Location.Y);
                    hunter.Location = new Point(hunter.Location.X - x, hunter.Location.Y);
                    if (target[i].Bounds.IntersectsWith(hunter.Bounds) && target[i].Visible)
                    {
                        target[i].ImageLocation = "D:/dead.PNG";
                        target[i].Dispose();
                        score = score + 1;
                        label1.Text = "Score: " + score;
                        target[i].BringToFront();


                    }
                }

            }
            if (target == null)
            {
                timer1.Stop();
            }




        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
