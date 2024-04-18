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

    public class SpecialRequestService : ISpecialRequestService
    {
       private readonly ISpecialRequestRepository specialRequestRepository;

        public SpecialRequestService(ISpecialRequestRepository specialRequestRepository)
        {
            this.specialRequestRepository = specialRequestRepository;
        }

        public void CreateRequest(Specialrequest request)
        {
            this.specialRequestRepository.CreateRequest(request);
        }

        public void DeleteRequest(int requestId)
        {
            this.specialRequestRepository.DeleteRequest(requestId);
        }

        public List<Specialrequest> GetAllRequests()
        {
            return this.specialRequestRepository.GetAllRequests();
        }

        public Specialrequest GetRequestById(int requestId)
        {
            return this.specialRequestRepository.GetRequestById(requestId);
        }

        public void UpdateRequest(Specialrequest request)
        {
            this.specialRequestRepository.UpdateRequest(request);
        }
    }


}
