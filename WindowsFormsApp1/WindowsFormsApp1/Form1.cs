using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            
            Color randomColor  = Color.FromArgb(random.Next(256),random.Next(256) , random.Next(256));

            button1.BackColor = randomColor;
            MessageBox.Show("Button color has been changed ! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            button2.BackColor = randomColor;
            MessageBox.Show("Button color has been changed ! ");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            button3.BackColor = randomColor;
            MessageBox.Show("Button color has been changed ! ");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            button4.BackColor = randomColor;
            MessageBox.Show("Button color has been changed ! ");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            button5.BackColor = randomColor;
            MessageBox.Show("color has been changed ! ");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            button6.BackColor = randomColor;
            MessageBox.Show("Button color has been changed ! ");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.MouseClick += new MouseEventHandler(button_MouseClick);
            button2.MouseClick += new MouseEventHandler(button_MouseClick);
            button3.MouseClick += new MouseEventHandler(button_MouseClick);
            button4.MouseClick += new MouseEventHandler(button_MouseClick);
            button5.MouseClick += new MouseEventHandler(button_MouseClick);
            button6.MouseClick += new MouseEventHandler(button_MouseClick);
        }

        private void button_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button button = sender as Button;
                Controls.Remove(button);
                MessageBox.Show($"Button {button.Text} has been removed !");
            }
        }

       
    }
}
