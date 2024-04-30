using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ICampusConsumerRepository
    {
       List<Campusconsumer> GetAllConsumers();
        Campusconsumer GetConsumerById(int consumerId);
        void CreateConsumer(Campusconsumer consumer);
        void UpdateConsumer(Campusconsumer consumer);
        void DeleteConsumer(int consumerId);
    }
}
