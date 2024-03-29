using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        [HttpGet]
        [Route("GetAllPayments")]
        public List<Payment> GetAllPayments()
        {
            return paymentService.GetAllPayments();
        }

        [HttpGet]
        [Route("GetPaymentById/{id}")]
        public Payment GetPaymentById(int id)
        {
            return paymentService.GetPaymentById(id);
        }

        [HttpPost]
        [Route("CreatePayment")]
        public void CreatePayment(Payment payment)
        {
            paymentService.CreatePayment(payment);
        }

        [HttpPut]
        [Route("UpdatePayment")]
        public void UpdatePayment(Payment payment)
        {
            paymentService.UpdatePayment(payment);
        }

        [HttpDelete]
        [Route("DeletePayment/{id}")]
        public void DeletePayment(int id)
        {
            paymentService.DeletePayment(id);
        }
    }
}
