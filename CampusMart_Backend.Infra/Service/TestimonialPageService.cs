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
    public class TestimonialPageService : ITestimonialPageService
    {
       private readonly ITestimonialPageRepository testimonialPageRepository;

        public TestimonialPageService(ITestimonialPageRepository testimonialPageRepository)
        {
            this.testimonialPageRepository = testimonialPageRepository;
        }

        public void CreateTestimonialPage(Testimonialpage testimonialPage)
        {
            this.testimonialPageRepository.CreateTestimonialPage(testimonialPage);
        }

        public void DeleteTestimonialPage(int testimonialPageId)
        {
            this.testimonialPageRepository.DeleteTestimonialPage(testimonialPageId);
        }

        public List<Testimonialpage> GetAllTestimonialPages()
        {
            return this.testimonialPageRepository.GetAllTestimonialPages();
        }

        public Testimonialpage GetTestimonialPageById(int testimonialPageId)
        {
            return this.testimonialPageRepository.GetTestimonialPageById(testimonialPageId);
        }

        public void UpdateTestimonialPage(Testimonialpage testimonialPage)
        {
            this.testimonialPageRepository.UpdateTestimonialPage(testimonialPage);
        }
    }
}
