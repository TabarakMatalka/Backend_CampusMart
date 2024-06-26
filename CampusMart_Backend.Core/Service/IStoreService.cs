﻿using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface IStoreService
    {
       List<Store> GetAllStores();
        Store GetStoreById(int storeId);
        void CreateStore(Store store);
        void UpdateStore(Store store);
        void DeleteStore(int storeId);
        List<Store> GetAllStoresFromAllProviders();
        List<Store> GetAllPendingStores();
        void UpdateStoreApprovalStatus(int storeId, string newStatus);

        Store GetStoreInfoByProviderID(int providerId);

        List<string> GetAllCategoriesByStoreID(int storeID);


    }
}
