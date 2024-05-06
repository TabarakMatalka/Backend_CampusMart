using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Service
{
    public interface ICampusServiceProviderService
    {
      List<Campusserviceprovider> GetAllServiceProviders();
        Campusserviceprovider GetServiceProviderById(int providerId);
        void CreateServiceProvider(Campusserviceprovider provider);
        void UpdateServiceProvider(Campusserviceprovider provider);
        void DeleteServiceProvider(int providerId);

        List<Campusserviceprovider> GetAllPendingServiceProviders();
        void AcceptServiceProvider(int consumerId, int providerId);
        void RejectServiceProvider(int consumerId, int providerId);
    }
}
