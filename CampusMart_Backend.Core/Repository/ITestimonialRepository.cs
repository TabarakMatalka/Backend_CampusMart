using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ITestimonialRepository
    {
        List<Testimonial> GetAllTestimonials();
        Testimonial GetTestimonialById(int testimonialId);
        void CreateTestimonial(Testimonial testimonial);
        void UpdateTestimonial(Testimonial testimonial);
        void DeleteTestimonial(int testimonialId);
        void UpdateTestimonialStatus(int testimonialId, string newStatus);

    }
}
