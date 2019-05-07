using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_VP_Summer
{
    public partial class Form1 : Form
    {
        int dcard1, dcard2 = 0;
        int dcard3 = 0;
        int dscore = 0;
        int drawcount = 0;
        int pcard1, pcard2, pcard3, pcard4,pcard5= 0;
        int psum = 0;
        string[] deck = new string[] {"2_of_hearts", "3_of_hearts", "4_of_hearts", "5_of_hearts", "6_of_hearts", "7_of_hearts", "8_of_hearts", "9_of_hearts", "10_of_hearts",
"2_of_clubs", "3_of_clubs", "4_of_clubs", "5_of_clubs", "6_of_clubs", "7_of_clubs", "8_of_clubs", "9_of_clubs", "10_of_clubs",
"2_of_diamonds", "3_of_diamonds", "4_of_diamonds", "5_of_diamonds", "6_of_diamonds", "7_of_diamonds", "8_of_diamonds", "9_of_diamonds", "10_of_diamonds",
"2_of_spades", "3_of_spades", "4_of_spades", "5_of_spades", "6_of_spades", "7_of_spades", "8_of_spades", "9_of_spades", "10_of_spades",
"ace_of_clubs", "ace_of_hearts", "ace_of_diamonds", "ace_of_spades", "king_of_clubs", "king_of_hearts", "king_of_diamonds", "king_of_spades", "queen_of_clubs", "queen_of_spades", "queen_of_diamonds", "queen_of_hearts", "jack_of_clubs", "jack_of_spades", "jack_of_hearts", "jack_of_diamonds"};

        int[] decknum = new int[]{2,3,4,5,6,7,8,9,10,2,3,4,5,6,7,8,9,10,
2,3,4,5,6,7,8,9,10,2,3,4,5,6,7,8,9,10,11,11,11,11,10,10,10,10,10,10,10,10,10,10,10,10};

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dscore < 21 && dscore>psum)
            {
                MessageBox.Show("Dealer Wins");
            }
            if (dscore == 21)
            {
                MessageBox.Show("Dealer Wins");
            }
            if (dscore > 21)
            {
                MessageBox.Show("Player Wins");
            }
            if (psum == 21)
            {
                MessageBox.Show("Player Wins");
            }
            if (psum < 21 && psum> dscore)
            {
                MessageBox.Show("Player Wins");
            }
            if (psum == dscore)
            {
                MessageBox.Show("TIE");
            }
            if (psum == 21 && dscore == 21)
            {
                MessageBox.Show("TIE");
            }
            if (psum > 21 && dscore > 21)
            {
                MessageBox.Show("TIE");
            }
            if(dscore > 21 && psum < 21)
            {
                MessageBox.Show("Player Wins");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dcard1 = psum = dcard2 = dcard3 = dscore= drawcount = pcard1 = pcard2 = pcard3 = pcard4 = pcard5 = 0;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// INITIALIZATION
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dcard1 = decknum[rnd.Next(51)];
            pictureBox1.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\back.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\back.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            dcard2 = decknum[rnd.Next(51)];
            dscore = dcard1 + dcard2;
            if(dscore < 7)
            {
                dcard3 = decknum[rnd.Next(51)];
                dscore = dscore + dcard3;
            }
            int temp = rnd.Next(51);
            int temp2 = rnd.Next(51);
            pcard1 = decknum[temp];
            pcard2 = decknum[temp2];
            psum = pcard1 + pcard2;
            pictureBox5.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\" + deck[temp] +".png");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\" + deck[temp2] + ".png");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = Convert.ToString(psum);
        }

        /////Draw Card

        private void button2_Click(object sender, EventArgs e)
        {
            drawcount++;
            Random rnd = new Random();
            if (drawcount == 1)
            {
                int temp = rnd.Next(51);
                pcard3 = decknum[temp];
                psum = psum + pcard3;
                label3.Text = Convert.ToString(psum);
                pictureBox7.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\" + deck[temp] + ".png");
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (drawcount == 2)
            {
                int temp = rnd.Next(51);
                pcard4 = decknum[temp];
                psum = psum + pcard4;
                label3.Text = Convert.ToString(psum);
                pictureBox8.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\" + deck[temp] + ".png");
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (drawcount == 3)
            {
                int temp = rnd.Next(51);
                pcard5 = decknum[temp];
                psum = psum + pcard5;
                label3.Text = Convert.ToString(psum);
                pictureBox9.Image = Image.FromFile(@"C:\Users\Muhammad Ali\source\repos\Project_VP_Summer\Project_VP_Summer\png\" + deck[temp] + ".png");
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Count Exceeded");
            }
        }
    }
}
