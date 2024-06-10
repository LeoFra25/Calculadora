using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Franco
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 = 0;
        char operador; 

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarnumero(string numero)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            textBox1.Text += numero;
        }

        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            
            numero1 = Convert.ToDouble(textBox1.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                textBox1.Text = numero1.ToString();
            }
            else
            {

              textBox1.Text = "0";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;


  
           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            Size = new Size(470, 350);
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void programadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel6.Visible = false;

        }

        private void button132_Click(object sender, EventArgs e)
        {

        }

        private void estadíditicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel6.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Size = new Size(255,340);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Size = new Size(255, 355);
        }

        private void conversiónDeUnidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Size = new Size(650, 360);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Size = new Size(470, 350);
        }

        private void button141_Click(object sender, EventArgs e)
        {

        }

        private void button105_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void conversiónDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conversiónDeUnidadesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Size = new Size(850, 350);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = true;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button56_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);

           // textBox1.Text = textBox1.Text + '1';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);

           // textBox1.Text = textBox1.Text + '2';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarnumero(boton.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {   var boton = ( (Button)sender);
            agregarnumero(boton.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(textBox1.Text);

            if (operador == '+')
            {
                textBox1.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(textBox1.Text);
            }
            else if (operador == '-')
            {
                textBox1.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(textBox1.Text);
            }
            else if (operador == '*')
            {
                textBox1.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(textBox1.Text);
            }
            else if (operador == '/')
            {
                textBox1.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(textBox1.Text);
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador= '\0';
            textBox1.Text="0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1.Text);
            numero1 *= -1;
            textBox1.Text = numero1.ToString();
        }
    }
}
