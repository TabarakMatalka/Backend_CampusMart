using CampusMart_Backend.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Core.Repository
{
    public interface ITestimonialPageRepository
    {
        List<Testimonialpage> GetAllTestimonialPages();
        Testimonialpage GetTestimonialPageById(int testimonialPageId);
        void CreateTestimonialPage(Testimonialpage testimonialPage);
        void UpdateTestimonialPage(Testimonialpage testimonialPage);
        void DeleteTestimonialPage(int testimonialPageId);
    }
}
