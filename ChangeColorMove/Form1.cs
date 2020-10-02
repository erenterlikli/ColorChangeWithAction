using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeColorMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if(e.KeyCode==Keys.D)
            {
                x = x + 5;
            }
            if(e.KeyCode==Keys.A)
            {
                x = x - 5;
            }

            if(e.KeyCode==Keys.W)
            {
                y = y - 5;
            }
            if(e.KeyCode==Keys.S)
            {
                y = y + 5;
            }

            //çapraz
            if(e.KeyCode==Keys.G)
            {
                x = x + 5;
                y = y + 5;
            }
            if(e.KeyCode==Keys.T)
            {
                x = x - 5;
                y = y - 5; 
            }
            if(pictureBox1.Right>label4.Left)
            {
                label4.BackColor = Color.Red;
            }
            if(pictureBox1.Left<label3.Right)
            {
                label3.BackColor = Color.Blue;
            }
            if(pictureBox1.Top<label1.Bottom)
            {
                label1.BackColor = Color.Green;
            }
            if(pictureBox1.Bottom>label2.Top)
            {
                label2.BackColor = Color.Yellow;
            }

            pictureBox1.Location = new Point(x, y);
        
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
