using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2Cert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Carro car = new Carro();
        List<Carro> carros = new List<Carro>();
        int PessoasTotal = 0, aux = 0, ncarros = 0, IDpedido, aux2;
        

        private void button1_Click(object sender, EventArgs e)
        {
           ncarros = int.Parse(textBox1.Text);
           textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ncarros; i++)
            {
                
                
                car.SetId(i + 1);
                Console.WriteLine("Escreva o modelo do carro: ");
                car.SetModelo(textBox2.Text);
                Console.WriteLine("Escreva a marca do carro: ");
                car.SetMarca(textBox3.Text);
                Console.WriteLine("Escreva a placa do carro: ");
                car.SetPlaca(textBox4.Text);
                Console.WriteLine("Escreva o numeros de passageiros desse carro: ");
                aux = int.Parse(textBox5.Text);
                PessoasTotal = PessoasTotal + aux;
                car.SetNumPassageiros(aux);

                
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IDpedido = int.Parse(textBox6.Text);
            
            while(IDpedido != -1)
            {
                car.GetNumPassageiros();

                if (IDpedido == 0 || IDpedido > carros.Count)
                {
                    MessageBox.Show("NUMERO INVALIDO!!!");
                    break;
                }
            }
        }
    }
}
