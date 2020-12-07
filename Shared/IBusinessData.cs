using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturations.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> Factures { get; }

    }
}
