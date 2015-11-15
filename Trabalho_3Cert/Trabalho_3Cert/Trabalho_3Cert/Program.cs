using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Trabalho_3Cert
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = new MySqlConnection("Server=localhost;database=test;Uid=root;Pwd=");

            MySqlDataReader read = cmd.ExecuteReader();
            
            Usuario usu = new Usuario();



            bool loged = false;
                    
            while(loged == false)
            {
            Console.WriteLine("Login:");
            string log = Console.ReadLine();

            Console.WriteLine("Senha:");
            string psw = Console.ReadLine();


            if (read.HasRows)
             {

                while (read.Read())
                {
                    if (read.GetString(3) == log && read.GetString(5) == psw)
                    {

                        loged = true;
                    }

                    if (read.GetString(3) != log && read.GetString(5) == psw)
                    {
                        Console.WriteLine("Nome de usuario e/ou senha incorretos");
                    }


                }

             }
            }


            while (loged == true)
            {
                Console.WriteLine("Bem vindo {0},", usu.Nome);
                Console.WriteLine("  Seu login foi efetuado com sucesso!!!");
                Console.WriteLine("\r\n" + "Ultimo acesso em {0}", usu.UltimoRegistro);
                Console.WriteLine("Digite 'sair' para fazer logout...");
                string ctrl = Console.ReadLine();
                ctrl.ToLower();

                if (ctrl == "sair")
                {

                    usu.UltimoRegistro = DateTime.Now;
                    loged = false;
                }
            }


        }

    }
}
