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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        private int rand_num;
        private int win_rate = 0;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
   
        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            rand_num = random.Next(1, 4);
     
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            

            pictureBox5.Image = Image.FromFile("1(2).jpg");

            if (rand_num == 1)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "LOSE!";
                pictureBox4.Image = Image.FromFile("rock.jpg");
            }

            if (rand_num == 2)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "WIN!";
                win_rate++;
                textBox1.Text = Convert.ToString(win_rate);
                pictureBox4.Image = Image.FromFile("paper.jpg");
            }

            if (rand_num == 3)
            {
                label3.ForeColor = Color.Black;
                label3.Text = "DRAW!";
                pictureBox4.Image = Image.FromFile("scissors.jpg");
            }
            
        }



            

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(win_rate);
        }
      
        private void pictureBox2_Click(object sender, EventArgs e) 
        {
            rand_num = random.Next(1, 4);
            pictureBox5.Image = null;
            pictureBox7.Image = null;
            

            pictureBox6.Image = Image.FromFile("1(2).jpg");

            if (rand_num == 1)
            {
                label3.ForeColor = Color.Black;
                label3.Text = "DRAW!";
                pictureBox4.Image = Image.FromFile("rock.jpg");
            }

            if (rand_num == 2)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "LOSE!";
                pictureBox4.Image = Image.FromFile("paper.jpg");
            }

            if (rand_num == 3)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "WIN!";
                win_rate++;
                textBox1.Text = Convert.ToString(win_rate);
                pictureBox4.Image = Image.FromFile("scissors.jpg");
            }
        }
 
        private void pictureBox3_Click(object sender, EventArgs e) 
        {
            rand_num = random.Next(1, 4);
            pictureBox6.Image = null;
            pictureBox5.Image = null;
            

            pictureBox7.Image = Image.FromFile("1(2).jpg");

            if (rand_num == 1)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "WIN!";
                win_rate++;
                textBox1.Text = Convert.ToString(win_rate);
                pictureBox4.Image = Image.FromFile("rock.jpg");
            }

            if (rand_num == 2)
            {
                label3.ForeColor = Color.Black;
                label3.Text = "DRAW!";
                pictureBox4.Image = Image.FromFile("paper.jpg");
            }

            if (rand_num == 3)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "LOSE!";
                pictureBox4.Image = Image.FromFile("scissors.jpg");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            win_rate = 0;
            textBox1.Text = Convert.ToString(win_rate);
            label3.Text = "";
            pictureBox4.Image = Image.FromFile("1(1).jpg");
            pictureBox6.Image = null;
            pictureBox5.Image = null;
            pictureBox7.Image = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
