using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KalkulatorLibrary; 

namespace KalkualtorApp
{
    public partial class Form1 : Form
    {
        Obliczenia obl = new Obliczenia();        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int wynik = obl.Dodaj(a, b);

            textBox3.Text = wynik.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int wynik = obl.Odejmij(a, b);

            textBox3.Text = wynik.ToString(); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a= Convert.ToInt32(textBox1.Text);
            int b= Convert.ToInt32(textBox2.Text);

            int wynik = obl.Pomnoz(a, b); 

            textBox3.Text = wynik.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if(a==0 || b==0)
            {
                MessageBox.Show("Nie mozna dzielic przez 0!"); 
            }
            int wynik = obl.Podziel(a, b);
            textBox3.Text = wynik.ToString(); 
        }
    }
}
