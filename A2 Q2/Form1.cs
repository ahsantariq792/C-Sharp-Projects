using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 350);
            Button[] b = new Button[3];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Button();
                b[i].Text = "Click Me:" + i; 
                b[i].Size = new Size(150, 20);
                b[i].Location = new Point(130, 50 - (i * 20));
                this.Controls.Add(b[i]);
            }

            Label[] label = new Label[3];
            for (int i = 0; i < label.Length; i++)
            {
                label[i] = new Label();
                label[i].Text = "Label " + i;  
                
                label[i].Size = new Size(200, 100);
                label[i].Location = new Point(180, 200 - (i * 20));
                this.Controls.Add(label[i]);
            }

            TrackBar A = new TrackBar();
            A.Size = new Size(360, 50);
            A.Location = new Point(20, 220);
            this.Controls.Add(A);
            A.BringToFront();

            TextBox[] textbox = new TextBox[4];
            for (int i = 0; i < textbox.Length; i++)
            {
                textbox[i] = new TextBox();
                textbox[i].Text = "Text Box:" + i;
                textbox[i].TextAlign = HorizontalAlignment.Center;
                textbox[i].Size = new Size(200, 300);
                textbox[i].Location = new Point(100, 135 - (i * 20));
                this.Controls.Add(textbox[i]);
            }       


        }    
    }
}
