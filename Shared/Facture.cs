using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturations.Shared
{
    public class Facture
    {
        public Facture(string num)
        {
            NumeroFacture = num;
        }
        public string NumeroFacture { get; set; }
    }
}
