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

        [HttpGet]
        [Route("GetStoreInfoByProviderID")]
        public Store GetStoreInfoByProviderID(int providerId)
        {
            return this.storeService.GetStoreInfoByProviderID(providerId);
        }

        [Route("uploadStoreImage")]
        [HttpPost]
        public IActionResult UploadImage()
        {
            var file = Request.Form.Files[0];

            if (file != null && (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg" || file.ContentType == "image/png"))
            {
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("C:\\Users\\user\\Desktop\\GP\\github\\frontend\\CampusMart\\src\\assets\\img\\shops", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Store item = new Store();
                item.Image = fileName;
                return Ok(item);
            }
            else
            {
                return BadRequest("Invalid file format. Please upload an image file.");
            }
        }
    }
}
