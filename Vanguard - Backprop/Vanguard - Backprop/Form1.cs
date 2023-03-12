using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanguard___Backprop
{
    public partial class Form1 : Form
    {   //Initialize a neural net that has 4 input neurons, 1 hidden and output neuron.
        NeuralNet c = new NeuralNet(4, 10, 1);
        double[] targetOutputs = {0.0, 1.0, 2.0, 3.0, 4.0};

        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            c.setInputs(0, Convert.ToDouble(textBox1.Text));
            c.setInputs(1, Convert.ToDouble(textBox2.Text));
            c.setInputs(2, Convert.ToDouble(textBox3.Text));
            c.setInputs(3, Convert.ToDouble(textBox4.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Convert.ToInt32(textBox6.Text); i++)
            {
                c.learn();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = c.getOuputData(0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.setDesiredOutput(0,Convert.ToDouble(textBox5.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.saveWeights("D:\\Weights.txt");
        }
    }
}
