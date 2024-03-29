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

    public class StoreService : IStoreService
    {
        private readonly IStoreRepository storeRepository;

        public StoreService(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        public void CreateStore(Store store)
        {
            this.storeRepository.CreateStore(store);
        }

        public void DeleteStore(int storeId)
        {
            this.storeRepository.DeleteStore(storeId);
        }

        public List<Store> GetAllStores()
        {
            return this.storeRepository.GetAllStores();
        }

        public Store GetStoreById(int storeId)
        {
            return this.storeRepository.GetStoreById(storeId);
        }

        public void UpdateStore(Store store)
        {
            this.storeRepository.UpdateStore(store);
        }
    }
}
