using Facturations.Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace Facturations.Server.Models
{
    //ATELIER 4
    public class BusinessDataSql : IBusinessData, IDisposable
    {
        private SqlConnection cnct;
        public BusinessDataSql(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            cnct.Dispose();
        }
        public IEnumerable<Facture> AllFactures => cnct.Query<Facture>("Select * FROM factures");

        public decimal CAReel => cnct.QueryFirstOrDefault<decimal>("Select SUM(paid) FROM factures");

        public decimal CAPrevisionnel => cnct.QueryFirstOrDefault<decimal>("Select SUM(amount) FROM factures");

        public void AjouterFacture(Facture facture)
        {
            //Debug.WriteLine(facture);
            var sql = "INSERT INTO Factures (NumeroFacture, Customer, Created, Expected, Amount, Paid) values (@NumeroFacture, @Customer, @Created, @Expected, @Amount, @Paid); SELECT CAST(SCOPE_IDENTITY() as int)";
            var returnId = cnct.ExecuteScalar<int>(sql, facture);
        }

    }
}
