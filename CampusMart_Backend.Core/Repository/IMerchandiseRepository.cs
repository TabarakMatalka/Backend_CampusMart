﻿using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface IMerchandiseRepository
    {
        List<Merchandise> GetAllMerchandise();
        Merchandise GetMerchandiseById(int merchandiseId);
        void CreateMerchandise(Merchandise merchandise);
        void UpdateMerchandise(Merchandise merchandise);
        void DeleteMerchandise(int merchandiseId);

        List<Merchandise> GetAllPendingMerchandise();
        void UpdateMerchandiseRequestStatus(int merchandiseId, string newStatus);

        List<Merchandise> GetMerchandiseInfoByStoreID(int storeId);
    }
}
