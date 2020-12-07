using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturations.Shared
{
    public class BusinessData : IBusinessData
    {
        public BusinessData()
        {
            Factures = new Facture[]
            {
                new Facture("F0001"),
                new Facture("F0002")
            };
        }
        public IEnumerable<Facture> Factures { get; }
    }
}
