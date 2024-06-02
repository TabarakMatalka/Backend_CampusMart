using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Store> GetAllStoresFromAllProviders()
        {
            return this.storeRepository.GetAllStoresFromAllProviders();
        }

        public List<Store> GetAllPendingStores()
        {
            return this.storeRepository.GetAllPendingStores();
        }
        public void UpdateStoreApprovalStatus(int storeId, string newStatus)
        {
            this.storeRepository.UpdateStoreApprovalStatus(storeId, newStatus);
        }


        public Store GetStoreInfoByProviderID(int providerId)
        {
           
            return this.storeRepository.GetStoreInfoByProviderID(providerId);
        }

        public List<string> GetAllCategoriesByStoreID(int storeID)
        {
            return this.storeRepository.GetAllCategoriesByStoreID(storeID);
        }


    }
}
