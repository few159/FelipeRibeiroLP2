using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felipes_Augusto_e_Ribeiro_23._06
{
    class Funcionarios
    {
        public DateTime dn;
        public double s;
        public int cpf;
        public double sn;
        public DateTime da;
        public string nome;

        public double aumento()
        {
            double aumento = 0;

            if (da.Year >= 2014)
            {
                aumento = 423.45;
            }

            else if (da.Year >= 2010 && da.Year <= 2013)
            {
                aumento = (s * 9.84 / 100);
            }

            else if (da.Year >= 2000 && da.Year <= 2009)
            {
                aumento = (s * 16.4 / 100);
            }

            else if (da.Year <= 1999)
            {
                aumento = (s * 22.6 / 100);
            }

            return aumento;
        }
    }
}
