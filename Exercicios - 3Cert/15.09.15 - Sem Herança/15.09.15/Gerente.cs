﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._09._15
{
    class Gerente
    {
        public string AreaGerenciada { get; set; }
        public double Adicional { get; set; }

        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime DNascimento { get; set; }
        public double Salario { get; set; }
        public string Matricula { get; set; }

        public double STotal() 
        {
            return Salario + Adicional;
        }
    }
}
