using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ISpecialRequestRepository
    {
       List<Specialrequest> GetAllRequests();
        Specialrequest GetRequestById(int requestId);
        void CreateRequest(Specialrequest request);
        void UpdateRequest(Specialrequest request);
        void DeleteRequest(int requestId);
    }
}
