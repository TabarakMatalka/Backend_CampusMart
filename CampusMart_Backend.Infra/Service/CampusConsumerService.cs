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
    public class CampusConsumerService : ICampusConsumerService
    {
        private readonly ICampusConsumerRepository campusConsumerRepository;

        public CampusConsumerService(ICampusConsumerRepository campusConsumerRepository)
        {
            this.campusConsumerRepository = campusConsumerRepository;
        }

        public void CreateConsumer(Campusconsumer consumer)
        {
            this.campusConsumerRepository.CreateConsumer(consumer);
        }

        public void DeleteConsumer(int consumerId)
        {
            this.campusConsumerRepository.DeleteConsumer(consumerId);
        }

        public List<Campusconsumer> GetAllConsumers()
        {
            return this.campusConsumerRepository.GetAllConsumers();
        }

        public Campusconsumer GetConsumerById(int consumerId)
        {
            return this.campusConsumerRepository.GetConsumerById(consumerId);
        }

        public void UpdateConsumer(Campusconsumer consumer)
        {
            this.campusConsumerRepository.UpdateConsumer(consumer);
        }
    }

}
