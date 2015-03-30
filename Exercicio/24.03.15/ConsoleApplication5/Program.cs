using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            double x = 0, salmao = 0 , atum = 20000000000000000, sushi = 0;

            Console.WriteLine("Escreva quantos numeros você precisar executar:");
            value = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < value; i++)
            {
               
                x = double.Parse(Console.ReadLine());


                if (x > salmao)
                {
                    salmao = x;
                }

                if (x < atum)
                {
                    atum = x;
                }

                sushi = x + sushi;
}

            Console.WriteLine("o maior numero é: {0}.         o menor é {1}.           e a soma de todos é {2}", salmao, atum, sushi);
            //se juntar o atum e salmao da um sushi, por isso q a soma tem esse nome (piada ruim mereçe ponto extra)
        }
    }
}
