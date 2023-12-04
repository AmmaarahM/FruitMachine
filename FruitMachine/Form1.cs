using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMachine
{
    public partial class Form1 : Form
    {

        static Image img1 = FruitMachine.Properties.Resources.Fall__1_;
        static Image img2 = FruitMachine.Properties.Resources.Idle__1_;
        static Image img3 = FruitMachine.Properties.Resources.Jump__1_;
        static Image img4 = FruitMachine.Properties.Resources.Jump__5_;
        static Image img5 = FruitMachine.Properties.Resources.Walk__4_;
        Image[] images = {img1,img2,img3,img4,img5};
        int counter;

        public Form1()
        {
            InitializeComponent();   
        }


        public void button1_Click_1(object sender, EventArgs e)
        {
            bool buttonclicked = true;
            if (buttonclicked)
            {
                  
            }
        }

        public void winchecker()
        {
            if(pictureBox1.Image == pictureBox2.Image && pictureBox2.Image == pictureBox3.Image)
            {
                int credit = Int32.Parse(label2.Text);
                credit = credit + 2;
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int nudge = Int32.Parse(label5.Text);
            while(nudge!=0)
            {
                nudge = nudge - 1;
                label5.Text = nudge.ToString();
            }
        }
        

        public void Form1_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(play);
            tmr.Start();
           
        }
        public void play(object sender, EventArgs e)
        {
            pictureBox1.Image = images[counter++];
            if (counter >= images.Length)
            { counter = 0; }
            pictureBox2.Image = images[counter++];
            if (counter >= images.Length)
            { counter = 0; }
            pictureBox3.Image = images[counter++];
            if (counter >= images.Length)
            { counter = 0; }
        }
    }
}
