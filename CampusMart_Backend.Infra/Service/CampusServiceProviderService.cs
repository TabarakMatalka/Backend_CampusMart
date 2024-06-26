﻿using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.DTO;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Service
{
    public class CampusServiceProviderService : ICampusServiceProviderService
    {
        private readonly ICampusServiceProviderRepository campusServiceProviderRepository;

        public CampusServiceProviderService(ICampusServiceProviderRepository campusServiceProviderRepository)
        {
            this.campusServiceProviderRepository = campusServiceProviderRepository;
        }

        public void CreateServiceProvider(Campusserviceprovider provider)
        {
            this.campusServiceProviderRepository.CreateServiceProvider(provider);
        }

        public void DeleteServiceProvider(int providerId)
        {
            this.campusServiceProviderRepository.DeleteServiceProvider(providerId);
        }

        public List<Campusserviceprovider> GetAllServiceProviders()
        {
            return this.campusServiceProviderRepository.GetAllServiceProviders();
        }

        public Campusserviceprovider GetServiceProviderById(int providerId)
        {
            return this.campusServiceProviderRepository.GetServiceProviderById(providerId);
        }

        public void UpdateServiceProvider(Campusserviceprovider provider)
        {
            this.campusServiceProviderRepository.UpdateServiceProvider(provider);
        }

        public List<Campusserviceprovider> GetAllPendingServiceProviders()
        {
            return this.campusServiceProviderRepository.GetAllPendingServiceProviders();
        }

        public void AcceptServiceProvider(int consumerId, int providerId)
        {
            this.campusServiceProviderRepository.AcceptServiceProvider(consumerId, providerId);
        }
        public void RejectServiceProvider(int consumerId, int providerId)
        {
            this.campusServiceProviderRepository.RejectServiceProvider(consumerId, providerId);
        }

        public ProviderStoreInfo GetProviderStoreInfoByConsumerID(int consumerId)
        {
            return this.campusServiceProviderRepository.GetProviderStoreInfoByConsumerID(consumerId);
        }
    }

}
