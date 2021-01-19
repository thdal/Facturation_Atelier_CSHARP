using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturations.Shared
{
    //ATELIER 3
    public class BusinessData : IBusinessData
    {
        private Facture[] factures =
        {
            new Facture("F0001", "FOO", 2154.6m     , 1250.1m, DateTime.Now),
            new Facture("F0002", "BAR", 12154.6m    , 9550.22m, DateTime.Now),
            new Facture("F0003", "BAR", 254.6m      , 80.90m, DateTime.Now),
            new Facture("F0004", "BOO", 32154.52m   , 18890.8m, DateTime.Now)
        };

        public BusinessData()
        {
            factures[3].Expected = DateTime.Now;
        }

        public IEnumerable<Facture> AllFactures => factures;        

        public void AjouterFacture(Facture facture)
        {
            Array.Resize(ref factures, factures.Length + 1);
            this.factures[factures.Length -1] = facture;
        }

        public decimal CAReel => factures.Sum(fact => fact.Paid);

        public decimal CAPrevisionnel => factures.Sum(Fact => Fact.Amount - Fact.Paid );

    }
}