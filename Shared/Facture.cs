using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturations.Shared
{
    public class Facture
    {
        public Facture(string numeroFacture, string customer, decimal amount, decimal paid, DateTime created)
        {
            NumeroFacture = numeroFacture;
            Customer = customer;
            Amount = amount;
            Created = created;
            Expected = created + TimeSpan.FromDays(30);
            Paid = paid;
        }
        public Facture()
        {

        }

        [Required(ErrorMessage = "Invoice reference is required")]
        public string NumeroFacture { get; set; }
        [Required(ErrorMessage = "La reference client est attendu")]
        public string Customer { get; set; }
        [Required(ErrorMessage = "Amount reference is required")]
        public decimal Amount { get; set; }
        public decimal Paid { get; private set; } = 0m;
        public DateTime Created { get; set; }
        public DateTime Expected { get; set; }
        public DateTime? LastPayment { get; private set; } = null;

        public bool IsPaid => Paid == Amount;
        public bool IsLate => Expected < DateTime.Now;

        public void RegisterPayment(DateTime when, decimal howMany)
        {
            if (when < Created)
            {
                throw new ArgumentOutOfRangeException("Cannot pay before the invoice creation");
            }
            LastPayment = when;
            if (Amount - Paid < howMany)
            {
                throw new ArgumentOutOfRangeException("Cannot pay over the due amount");
            }
            Paid += howMany;
        }


    }
}













