using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_de_Exercios_1
{
    class Program
    {

        //corrigir exercicios 2 e 8!!!!!!!
        static void Main(string[] args)
        {
        }

        static void Exercicio1() 
        {
            int n, x = 1;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                x *= n - i;

            }
            Console.WriteLine("{0}", x);
        
        }



        static void Exercicio2()
        {
            int N, x = 1;
            Console.WriteLine("N:");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                x *= N - i;
                int result = x / (2 * i) + 1;
            }
        }


        static void Exercicio3()
        {
            Console.WriteLine("Digite o numero de funcionarios:");
            int func = int.Parse(Console.ReadLine());
            double sal, reajust;
            string nome;

            for (int i = 0; i < func; i++)
            {
                Console.WriteLine("digite o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Digite seu salario ATUAL:");
                sal = double.Parse(Console.ReadLine());

                if (sal > -1 && sal < 2999)
                {
                    reajust = sal * 1.25;
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario Reajustado:{2}", nome, sal, reajust);
                    Console.WriteLine("\r\n");
                }
                if (sal > 2999 && sal < 3999)
                {
                    reajust = sal / 1 / 4 + sal;
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario Reajustado:{2}", nome, sal, reajust);
                    Console.WriteLine("\r\n");
                }
                if (sal > 3999 && sal < 4999)
                {
                    reajust = sal * 1.15;
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario Reajustado:{2}", nome, sal, reajust);
                    Console.WriteLine("\r\n");
                }
                if (sal > 4999)
                {
                    reajust = sal * 1.10;
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Nome:{0}    Salario Atual:{1}    Salario Reajustado:{2}", nome, sal, reajust);
                    Console.WriteLine("\r\n");
                }

            }
        }



        static void Exercicio4()
        {
            string x;
            int pj1 = 0, pj2 = 0;

            Console.WriteLine("Para marcar pontos do jogador 1, digite A. \r\n Para marcar pontos do jogador 2, digite B");


            while (true)
            {

                if ((pj1 < 21 || pj1 < pj2 + 2) && (pj2 < 21 || pj2 < pj1 + 2))
                {
                    x = Console.ReadLine().ToLower();

                    switch (x)
                    {
                        case "a":
                            pj1++;
                            break;
                        case "b":
                            pj2++;
                            break;
                    }


                    Console.WriteLine("Jogardor 1: {0}.   Jogador 2: {1}", pj1, pj2);
                }
            }
        }



        static void Exercicio5()
        {
            double km = 0, litros = 50, media = 0;

            while (litros > 0 && km < 600)
            {
                Console.WriteLine("Escreva quantos km ja foram percorridos");
                km = double.Parse(Console.ReadLine());

                Console.WriteLine("Escreva quantos litros ja foram usados");
                litros = double.Parse(Console.ReadLine());
            }

            if (litros == 0 && km < 600)
            {
                Console.WriteLine("A gasolina acabou no meio do caminho :(");
            }

            else { Console.WriteLine("O carro chegou ao seu destino!!!"); }
            media = km / litros;

            Console.WriteLine("A média de Km/L foi de: {0}", media);
        }



        static void Exercicio6() {string nome;
            int altura, x = 0, z = 0, y = 0,r = 0;
            int np = 999999999;

            for (int i = 0; i  < np; i ++)
            {
                Console.WriteLine("Nome:");
                nome = Console.ReadLine();
                switch (nome)
                {
                    case "Fim":
                    case "fim":
                    case "FIM":
                        i = np;
                        break;
                    default:
                        break;
                }
                if (nome != "fim")
                    if (nome != "FIM")
                        if (nome != "Fim")
                    {
                            Console.WriteLine("Altura (cm):");
                            altura = int.Parse(Console.ReadLine());
                            
                            if (altura == x) { z++; }

                            if (altura > x)
                            {
                                y = x;
                                x = altura;
                                z = 1;
                            }
                            if (altura == y) { r++; }
                            else if (altura < x && y < altura){
                                y = altura;
                                r = 1;
                            }
                    }
                Console.WriteLine("\r\n");

            }

            Console.WriteLine("A maior altura foi {0}cm, após {1}cm , {2} pessoas tem a maior altura e {3} tem a segunda maior", x, y, z, r);
        }

        static void Exercicio7() { }

        static void Exercicio8()
        {
            Console.WriteLine("Escreva um numero:");
            int n = int.Parse(Console.ReadLine());
            int i = 0;

            while (i < n)
            {
                n = n + i;
                i++;
            }

            Console.WriteLine("{0}", n);
        }
    }
}
