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
    public class TestimonialService : ITestimonialService
    {
       private readonly ITestimonialRepository testimonialRepository;

        public TestimonialService(ITestimonialRepository testimonialRepository)
        {
            this.testimonialRepository = testimonialRepository;
        }

        public void CreateTestimonial(Testimonial testimonial)
        {
            this.testimonialRepository.CreateTestimonial(testimonial);
        }

        public void DeleteTestimonial(int testimonialId)
        {
            this.testimonialRepository.DeleteTestimonial(testimonialId);
        }

        public List<Testimonial> GetAllTestimonials()
        {
            return this.testimonialRepository.GetAllTestimonials();
        }

        public Testimonial GetTestimonialById(int testimonialId)
        {
            return this.testimonialRepository.GetTestimonialById(testimonialId);
        }

        public void UpdateTestimonial(Testimonial testimonial)
        {
            this.testimonialRepository.UpdateTestimonial(testimonial);
        }
        public void UpdateTestimonialStatus(int testimonialId, string newStatus)
        {
            this.testimonialRepository.UpdateTestimonialStatus(testimonialId, newStatus);
        }
    }

}
