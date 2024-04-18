using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly IDbContext dbContext;

        public BankRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Bank> GetAllBanks()
        {
            IEnumerable<Bank> result = dbContext.Connection.Query<Bank>("Bank_Package.GetAllBanks", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Bank GetBankById(int bankId)
        {
            var p = new DynamicParameters();
            p.Add("BankID_param", bankId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Bank>("Bank_Package.GetBankById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateBank(Bank bank)
        {
            var p = new DynamicParameters();
            p.Add("p_Username", bank.Username, DbType.String, ParameterDirection.Input);
            p.Add("p_Password", bank.Password, DbType.String, ParameterDirection.Input);
            p.Add("p_CardHolder", bank.Cardholder, DbType.String, ParameterDirection.Input);
            p.Add("p_CardNumber", bank.Cardnumber, DbType.String, ParameterDirection.Input);
            p.Add("p_Balance", bank.Balance, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_CVV", bank.Cvv, DbType.String, ParameterDirection.Input);
            p.Add("p_PaymentID", bank.Paymentid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ConsumerID", bank.Consumerid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Bank_Package.CreateBank", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateBank(Bank bank)
        {
            var p = new DynamicParameters();
            p.Add("p_BankID", bank.Bankid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_Username", bank.Username, DbType.String, ParameterDirection.Input);
            p.Add("p_Password", bank.Password, DbType.String, ParameterDirection.Input);
            p.Add("p_CardHolder", bank.Cardholder, DbType.String, ParameterDirection.Input);
            p.Add("p_CardNumber", bank.Cardnumber, DbType.String, ParameterDirection.Input);
            p.Add("p_Balance", bank.Balance, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_CVV", bank.Cvv, DbType.String, ParameterDirection.Input);
            p.Add("p_PaymentID", bank.Paymentid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_ConsumerID", bank.Consumerid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Bank_Package.UpdateBank", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteBank(int bankId)
        {
            var p = new DynamicParameters();
            p.Add("p_BankID", bankId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Bank_Package.DeleteBank", p, commandType: CommandType.StoredProcedure);
        }
    }
}
