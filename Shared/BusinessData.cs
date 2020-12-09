using System;
using System.Collections.Generic;
using System.Globalization;
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
                new Facture("F0001",
                "Durand",
                Convert.ToDateTime("06/12/2020"),
                Convert.ToDateTime("01/01/2021"),
                250,
                100),
                new Facture("F0002",
                "Dupond",
                Convert.ToDateTime("07/12/2020"),
                Convert.ToDateTime("01/02/2021"),
                450,
                200),
                new Facture("F0003",
                "Leblanc",
                Convert.ToDateTime("08/12/2020"),
                Convert.ToDateTime("01/03/2021"),
                850,
                300),
                new Facture("F0004",
                "De nior",
                Convert.ToDateTime("09/12/2020"),
                Convert.ToDateTime("01/04/2021"),
                1050,
                800),
                new Facture("F0005",
                "Lagrange",
                DateTime.Now,
                Convert.ToDateTime("01/01/2021"),
                2550,
                500),
                //new Facture("F0002")
            };
        }
        public IEnumerable<Facture> Factures { get; }

    }
}