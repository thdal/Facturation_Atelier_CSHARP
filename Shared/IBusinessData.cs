using System.Collections.Generic;

namespace Facturations.Shared
{
    public interface IBusinessData
    {
        IEnumerable<Facture> AllFactures { get; }

        void AjouterFacture(Facture facture);

        decimal CAReel { get; }

        decimal CAPrevisionnel { get; }

    }
}
