using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            float cent = float.Parse(this.textBox2.Text);
            float Far = (cent * 9 / 5) + 32;
            this.textBox1.Text = Far.ToString(); 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button2.Enabled = true;
            button1.Enabled = true;
            textBox1.Text = " ";
            textBox2.Text = "" ;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            float Far = float.Parse(this.textBox2.Text);
            float cent = (Far -32) * 5/9;
            this.textBox1.Text = cent.ToString();
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
