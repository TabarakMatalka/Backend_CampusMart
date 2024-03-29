using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface IBankService
    {
        List<Bank> GetAllBanks();
        Bank GetBankById(int bankId);
        void CreateBank(Bank bank);
        void UpdateBank(Bank bank);
        void DeleteBank(int bankId);
    }

}
