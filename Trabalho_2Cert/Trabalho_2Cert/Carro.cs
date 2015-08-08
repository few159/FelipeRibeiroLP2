using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_2Cert
{
    class Carro
    {
        int _id;
        string _modelo;
        string _marca;
        string _placa;
        int _Numpassageiros;

        public void SetId(int Id)
        {
            _id = Id;
        }
        public int GetId()
        {
            return _id;
        }
        public void SetModelo(string modelo)
        {
            _modelo = modelo;
        }
        public string GetModelo()
        {
            return _modelo;
        }
        public void SetMarca(string marca)
        {
            _marca = marca;
        }
        public string GetMarca()
        {
            return _modelo;
        }
        public void SetPlaca(string placa)
        {
            _placa = placa;
        }
        public string GetPlaca()
        {
            return _placa;
        }
        public void SetNumPassageiros(int passageiros)
        {
            _Numpassageiros = passageiros;
        }
        public int GetNumPassageiros()
        {
            return _Numpassageiros;
        }
    }
}
