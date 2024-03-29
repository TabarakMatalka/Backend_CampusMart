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
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IDbContext dbContext;

        public PaymentRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Payment> GetAllPayments()
        {
            IEnumerable<Payment> result = dbContext.Connection.Query<Payment>("Payment_Package.GetAllPayments", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Payment GetPaymentById(int paymentId)
        {
            var p = new DynamicParameters();
            p.Add("p_PaymentID", paymentId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Payment>("Payment_Package.GetPaymentById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreatePayment(Payment payment)
        {
            var p = new DynamicParameters();
            p.Add("p_Amount", payment.Amount, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_PaymentDate", payment.PaymentDate, DbType.Date, ParameterDirection.Input);
            p.Add("p_PaymentMethod", payment.PaymentMethod, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Payment_Package.Create_Payment", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdatePayment(Payment payment)
        {
            var p = new DynamicParameters();
            p.Add("p_PaymentID", payment.Paymentid, DbType.Int32, ParameterDirection.Input);
            p.Add("p_Amount", payment.Amount, DbType.Decimal, ParameterDirection.Input);
            p.Add("p_PaymentDate", payment.PaymentDate, DbType.Date, ParameterDirection.Input);
            p.Add("p_PaymentMethod", payment.PaymentMethod, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("Payment_Package.Update_Payment", p, commandType: CommandType.StoredProcedure);
        }

        public void DeletePayment(int paymentId)
        {
            var p = new DynamicParameters();
            p.Add("p_PaymentID", paymentId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Payment_Package.DeletePayment", p, commandType: CommandType.StoredProcedure);
        }
    }
}
