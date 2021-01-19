using System;
using System.ComponentModel.DataAnnotations;

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

        [Required(ErrorMessage = "Le numéro de la facture est obligatoire")]
        public string NumeroFacture { get; set; }
        [Required(ErrorMessage = "Le nom de client est obligatoire")]
        public string Customer { get; set; }
        [Required(ErrorMessage = "Le montant de la facture est obligatoire")]
        public decimal Amount { get; set; }
        public decimal Paid { get; set; } //= 0m;
        public DateTime Created { get; set; }
        public DateTime Expected { get; set; }

    }
}













