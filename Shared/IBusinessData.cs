using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturations.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> AllFactures { get; }

        void ajouterFacture(Facture facture);

        decimal SalesRevenue { get; }

        decimal Outstanding { get; }

    }
}
