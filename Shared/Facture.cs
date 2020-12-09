using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturations.Shared
{
    public class Facture
    {
        public Facture(string num, string client, DateTime dateEmission, DateTime dateReglement, int montantDu, int montantRegle )
        {
            this.NumeroFacture = num;
            this.Client = client;
            this.DateEmission = dateEmission;
            this.DateReglement = dateReglement;
            this.MontantDu = montantDu;
            this.MontantRegle = montantRegle;

        }
        public string NumeroFacture { get; set; }

        public string Client { get; set; }

        public DateTime DateEmission { get; set; }

        public DateTime DateReglement { get; set; }

        public int MontantDu { get; set; }

        public int MontantRegle { get; set; }


    }
}













