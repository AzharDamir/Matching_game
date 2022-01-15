using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUTO3
{
    public partial class Form1 : Form
    {
        int score = 0;
        Random r = new Random();
        List<Point> points = new List<Point>();
        //bool again = false;
        PictureBox PendingImage1;// 1ere image afficher
        PictureBox PendingImage2;// 2éme image 
        public Form1()
        {
            InitializeComponent();
        }

       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                
                int next = r.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            timer1.Start();
            card1.Image = Properties.Resources.img1;
            dupcard1.Image = Properties.Resources.img1;
            card2.Image = Properties.Resources.img2;
            dupcard2.Image = Properties.Resources.img2;
            card3.Image = Properties.Resources.img7;
            dupcard3.Image = Properties.Resources.img7;
            card4.Image = Properties.Resources.img4;
            dupcard4.Image = Properties.Resources.img4;
            card5.Image = Properties.Resources.img9;
            dupcard5.Image = Properties.Resources.img9;
            card6.Image = Properties.Resources.img8;
            dupcard6.Image = Properties.Resources.img8;
            card7.Image = Properties.Resources.img11;
            dupcard7.Image = Properties.Resources.img11;
            card8.Image = Properties.Resources.img10;
            dupcard8.Image = Properties.Resources.img10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            foreach (PictureBox picture in tableLayoutPanel1.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.cover;
            }
        }

        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Properties.Resources.img1;
            if (PendingImage1 == null) 
            { PendingImage1 = card1;
            }
            else if(PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card1;
            }
            if(PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card1.Enabled = false;
                    dupcard1.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;

                  
                }
                else
                {
                   timer2.Start();
                }
                
            }
           
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.img7;
            if (PendingImage1 == null)
            {
                PendingImage1 = card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card3;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card7.Enabled = false;
                    dupcard7.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }

        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.img4;
            if (PendingImage1 == null)
            {
                PendingImage1 = card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card4;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card4.Enabled = false;
                    dupcard4.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
               
            }
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.img9;
            if (PendingImage1 == null)
            {
                PendingImage1 = card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card5;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card5.Enabled = false;
                    dupcard5.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
             
            }
        }

        private void dupcard4_Click(object sender, EventArgs e)
        {
            dupcard4.Image = Properties.Resources.img4;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard4;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card4.Enabled = false;
                    dupcard4.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.img8;
            if (PendingImage1 == null)
            {
                PendingImage1 = card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card6;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card6.Enabled = false;
                    dupcard6.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources.img11;
            if (PendingImage1 == null)
            {
                PendingImage1 = card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card7;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card7.Enabled = false;
                    dupcard7.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }

        private void dupcard3_Click(object sender, EventArgs e)
        {
            dupcard3.Image = Properties.Resources.img7;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard3;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card3.Enabled = false;
                    dupcard3.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources.img10;
            if (PendingImage1 == null)
            {
                PendingImage1 = card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card8;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card8.Enabled = false;
                    dupcard8.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
             
            }
        }
    
       

        private void dupcard5_Click(object sender, EventArgs e)
        {
            dupcard5.Image = Properties.Resources.img9;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard5;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card5.Enabled = false;
                    dupcard5.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
              
            }
        }

        private void dupcard8_Click(object sender, EventArgs e)
        {
            dupcard8.Image = Properties.Resources.img10;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard8;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card8.Enabled = false;
                    dupcard8.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }

        private void dupcard1_Click(object sender, EventArgs e)
        {
            dupcard1.Image = Properties.Resources.img1;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard1;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card1.Enabled = false;
                    dupcard1.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
               
            }
        }

        private void dupcard7_Click(object sender, EventArgs e)
        {
            dupcard7.Image = Properties.Resources.img11;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard7;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card7.Enabled = false;
                    dupcard7.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
             
            }
        }

        private void dupcard6_Click(object sender, EventArgs e)
        {
            dupcard6.Image = Properties.Resources.img8;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard6;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card6.Enabled = false;
                    dupcard6.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            PendingImage1.Image = Properties.Resources.cover;
            PendingImage2.Image = Properties.Resources.cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void dupcard2_Click(object sender, EventArgs e)
        {
            dupcard2.Image = Properties.Resources.img2;
            if (PendingImage1 == null)
            {
                PendingImage1 = dupcard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dupcard2;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card2.Enabled = false;
                    dupcard2.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
                
            }
            
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.img2;
            if (PendingImage1 == null)
            {
                PendingImage1 = card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card2;
            }
            if (PendingImage2 != null && PendingImage1 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    card2.Enabled = false;
                    dupcard2.Enabled = false;
                    PendingImage1 = null;
                    PendingImage2 = null;
                }
                else
                {
                    timer2.Start();
                }
               
            }
           
        }
    }
}
