using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_11_12_Зад2_В9
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Figure a = new Figure();

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int q) & int.TryParse(textBox2.Text, out int w))
            {
                a.rectangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else
            {
                MessageBox.Show("В данных прямоугольника введены неверные значения");
            }

            if (textBox3.Text != "")
            {
                a.Circle(Convert.ToDouble(textBox3.Text));
            }
            else
            {
                MessageBox.Show("В данных круга введены неверные значения");
            }
            
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" &&  textBox7.Text != "" && textBox8.Text != "")
            {
                a.Triangle(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text),Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text));
            }
            else
            {
                MessageBox.Show("В данных треугольника введены неверные значения");
            }

            string[,] h = a.Vizov();
            int i = 0;
            while (i < 3)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 0 & j == 1)
                    {
                        label12.Text = $"Прямоугольник:\nПлощадь-{h[i,0]} Периметр-{h[i, 1]}\n";
                    }

                    if (i == 1 & j == 1)
                    {
                        label12.Text = label12.Text+ $"Круг:\nПлощадь-{h[i, 0]} Периметр-{h[i, 1]}\n" ;
                    }

                    if (i == 2 & j == 1)
                    {
                        label12.Text = label12.Text +$"Треугольник:\nПлощадь-{h[i, 0]} Периметр-{h[i, 1]}\n";
                    }  
                }
                i++;
            }
            label12.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
