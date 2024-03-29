using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusServiceProviderController : ControllerBase
    {
        private readonly ICampusServiceProviderService campusServiceProviderService;

        public CampusServiceProviderController(ICampusServiceProviderService campusServiceProviderService)
        {
            this.campusServiceProviderService = campusServiceProviderService;
        }

        [HttpGet]
        [Route("GetAllServiceProviders")]
        public List<Campusserviceprovider> GetAllServiceProviders()
        {
            return campusServiceProviderService.GetAllServiceProviders();
        }

        [HttpGet]
        [Route("GetServiceProviderById/{id}")]
        public Campusserviceprovider GetServiceProviderById(int id)
        {
            return campusServiceProviderService.GetServiceProviderById(id);
        }

        [HttpPost]
        [Route("CreateServiceProvider")]
        public void CreateServiceProvider(Campusserviceprovider provider)
        {
            campusServiceProviderService.CreateServiceProvider(provider);
        }

        [HttpPut]
        [Route("UpdateServiceProvider")]
        public void UpdateServiceProvider(Campusserviceprovider provider)
        {
            campusServiceProviderService.UpdateServiceProvider(provider);
        }

        [HttpDelete]
        [Route("DeleteServiceProvider/{id}")]
        public void DeleteServiceProvider(int id)
        {
            campusServiceProviderService.DeleteServiceProvider(id);
        }
    }
}
