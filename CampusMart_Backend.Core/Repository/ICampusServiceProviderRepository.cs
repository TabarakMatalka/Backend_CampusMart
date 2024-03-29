using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ICampusServiceProviderRepository
    {
        List<Campusserviceprovider> GetAllServiceProviders();
        Campusserviceprovider GetServiceProviderById(int providerId);
        void CreateServiceProvider(Campusserviceprovider provider);
        void UpdateServiceProvider(Campusserviceprovider provider);
        void DeleteServiceProvider(int providerId);
    }
}
