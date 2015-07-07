using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro c1 = new Carro();

            c1.placa = textBox1.Text;
            c1.modelo = textBox2.Text;
            c1.consumoKmL = double.Parse(textBox3.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

           textBox4.Text = String.Format("Placa: {0}"+ "\r\n" +"Modelo: {1}" + "\r\n" +" Consumo[L] por KM: {2}", c1.placa, c1.modelo, c1.consumoKmL);
            
        }
    }
}
