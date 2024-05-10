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

    public class MerchandiseService : IMerchandiseService
    {
        private readonly IMerchandiseRepository merchandiseRepository;

        public MerchandiseService(IMerchandiseRepository merchandiseRepository)
        {
            this.merchandiseRepository = merchandiseRepository;
        }

        public void CreateMerchandise(Merchandise merchandise)
        {
            this.merchandiseRepository.CreateMerchandise(merchandise);
        }

        public void DeleteMerchandise(int merchandiseId)
        {
            this.merchandiseRepository.DeleteMerchandise(merchandiseId);
        }

        public List<Merchandise> GetAllMerchandise()
        {
            return this.merchandiseRepository.GetAllMerchandise();
        }

        public Merchandise GetMerchandiseById(int merchandiseId)
        {
            return this.merchandiseRepository.GetMerchandiseById(merchandiseId);
        }

        public void UpdateMerchandise(Merchandise merchandise)
        {
            this.merchandiseRepository.UpdateMerchandise(merchandise);
        }

        public List<Merchandise> GetAllPendingMerchandise()
        {
            return this.merchandiseRepository.GetAllPendingMerchandise();
        }

     
        public void UpdateMerchandiseRequestStatus(int merchandiseId, string newStatus)
        {
            this.merchandiseRepository.UpdateMerchandiseRequestStatus(merchandiseId, newStatus);
        }

        public List<Merchandise> GetMerchandiseInfoByStoreID(int storeId)
        {
            return this.merchandiseRepository.GetMerchandiseInfoByStoreID(storeId);
        }

    }
}
