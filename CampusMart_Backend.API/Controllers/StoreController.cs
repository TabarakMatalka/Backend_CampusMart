using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService storeService;

        public StoreController(IStoreService storeService)
        {
            this.storeService = storeService;
        }

        [HttpGet]
        [Route("GetAllStores")]
        public List<Store> GetAllStores()
        {
            return storeService.GetAllStores();
        }

        [HttpGet]
        [Route("GetStoreById/{storeId}")]
        public Store GetStoreById(int storeId)
        {
            return storeService.GetStoreById(storeId);
        }

        [HttpPost]
        [Route("CreateStore")]
        public void CreateStore(Store store)
        {
            storeService.CreateStore(store);
        }

        [HttpPut]
        [Route("UpdateStore")]
        public void UpdateStore(Store store)
        {
            storeService.UpdateStore(store);
        }

        [HttpDelete]
        [Route("DeleteStore/{storeId}")]
        public void DeleteStore(int storeId)
        {
            storeService.DeleteStore(storeId);
        }

        [HttpGet]
        [Route("GetAllStoresFromAllProviders")]
        public List<Store> GetAllStoresFromAllProviders()
        {
            return storeService.GetAllStoresFromAllProviders();
        }



        [HttpGet]
        [Route("GetPendingStores")]
        public List<Store> GetAllPendingStores()
        {
            return storeService.GetAllPendingStores();
        }

        [HttpPut]
        [Route("UpdateStoreApprovalStatus/{storeId}/{newStatus}")]
        public void UpdateStoreApprovalStatus(int storeId, string newStatus)
        {
            storeService.UpdateStoreApprovalStatus(storeId, newStatus);
        }

    }
}
