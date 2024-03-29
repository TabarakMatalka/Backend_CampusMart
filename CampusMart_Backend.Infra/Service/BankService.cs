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
    public class BankService : IBankService
    {
        private readonly IBankRepository bankRepository;

        public BankService(IBankRepository bankRepository)
        {
            this.bankRepository = bankRepository;
        }

        public void CreateBank(Bank bank)
        {
            this.bankRepository.CreateBank(bank);
        }

        public void DeleteBank(int bankId)
        {
            this.bankRepository.DeleteBank(bankId);
        }

        public List<Bank> GetAllBanks()
        {
            return this.bankRepository.GetAllBanks();
        }

        public Bank GetBankById(int bankId)
        {
            return this.bankRepository.GetBankById(bankId);
        }

        public void UpdateBank(Bank bank)
        {
            this.bankRepository.UpdateBank(bank);
        }
    }

}
