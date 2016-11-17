using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RndColourGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  string hexV()
        {
            Random rnd = new Random();//creates random
            string hex = String.Format("#{0:X6}", rnd.Next(0x1000000));//creates random hex colour value
            return (hex);//returns hex colour value
        }

        private void button1_Click(object sender, EventArgs e)//raindom colour
        {
            var colour = ColorTranslator.FromHtml(hexV());//translats hex value to a colour
            this.BackColor = colour;//changes background colour
            label1.Text = Convert.ToString(this.BackColor);//displays what colour is being shown as a ARGB colour value
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Color [A=255, R=255, G=255, B=255]";
        }

        private void button2_Click(object sender, EventArgs e)//typed in colour
        {
            try
            {
                var colour = ColorTranslator.FromHtml(textBox1.Text);
                this.BackColor = colour;
            }
            catch
            {
                MessageBox.Show("Error:" + Environment.NewLine + "Please type in a valid hex colour.");
            }
        }
    }
}
