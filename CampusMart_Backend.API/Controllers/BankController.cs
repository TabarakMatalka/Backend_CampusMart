using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService bankService;

        public BankController(IBankService bankService)
        {
            this.bankService = bankService;
        }

        [HttpGet]
        [Route("GetAllBanks")]
        public List<Bank> GetAllBanks()
        {
            return bankService.GetAllBanks();
        }

        [HttpGet]
        [Route("GetBankById/{id}")]
        public Bank GetBankById(int id)
        {
            return bankService.GetBankById(id);
        }

        [HttpPost]
        [Route("CreateBank")]
        public void CreateBank(Bank bank)
        {
            bankService.CreateBank(bank);
        }

        [HttpPut]
        [Route("UpdateBank")]
        public void UpdateBank(Bank bank)
        {
            bankService.UpdateBank(bank);
        }

        [HttpDelete]
        [Route("DeleteBank/{id}")]
        public void DeleteBank(int id)
        {
            bankService.DeleteBank(id);
        }
    }
}
