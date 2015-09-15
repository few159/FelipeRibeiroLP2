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

        public double Salario { get; set; }

        public double STotal() 
        {
            return Salario + Adicional;
        }

        public double ValeAlimentacao()
        {
            double auxiliar = STotal() * 1.08;

            if (auxiliar > 750.00)
            {
                auxiliar = 750;
            }

            return auxiliar;
        }
    }
}
