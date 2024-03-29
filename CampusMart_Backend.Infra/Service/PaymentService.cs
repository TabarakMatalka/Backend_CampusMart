using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{

    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }

        public void CreatePayment(Payment payment)
        {
            this.paymentRepository.CreatePayment(payment);
        }

        public void DeletePayment(int paymentId)
        {
            this.paymentRepository.DeletePayment(paymentId);
        }

        public List<Payment> GetAllPayments()
        {
            return this.paymentRepository.GetAllPayments();
        }

        public Payment GetPaymentById(int paymentId)
        {
            return this.paymentRepository.GetPaymentById(paymentId);
        }

        public void UpdatePayment(Payment payment)
        {
            this.paymentRepository.UpdatePayment(payment);
        }
    }
}
