using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._09._15
{
    class Gerente : Funcionario
    {
        public string AreaGerenciada { get; set; }
        public double Adicional { get; set; }

        public double STotal() 
        {
            return Salario + Adicional;
        }
    }
}
