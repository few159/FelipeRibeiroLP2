using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o numero de carros: ");
            int ncaros = int.Parse(Console.ReadLine());

            List<Carro> carros = new List<Carro>();
            int PessoasTotal = 0, aux = 0;
            for (int i = 0; i < ncaros; i++)
            {
                Carro car = new Carro();

                car.SetId(i + 1);
                Console.WriteLine("Escreva o modelo do carro: ");
                car.SetModelo(Console.ReadLine());
                Console.WriteLine("Escreva a marca do carro: ");
                car.SetMarca(Console.ReadLine());
                Console.WriteLine("Escreva a placa do carro: ");
                car.SetPlaca(Console.ReadLine());
                Console.WriteLine("Escreva o numeros de passageiros desse carro: ");
                aux = int.Parse(Console.ReadLine());
                PessoasTotal = PessoasTotal + aux;
                car.SetNumPassageiros(aux);

            }


        }
    }
}
