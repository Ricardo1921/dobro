using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobro
{
    class conta
    {
        private double valor;

        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value) * 2;
            }
        }
        public string resultado
        {
            get
            {
                return valor.ToString();
            }
        }
    }
}
