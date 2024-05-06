using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }

        [HttpGet]
        [Route("GetAllTestimonials")]
        public List<Testimonial> GetAllTestimonials()
        {
            return testimonialService.GetAllTestimonials();
        }

        [HttpGet]
        [Route("GetTestimonialById/{testimonialId}")]
        public Testimonial GetTestimonialById(int testimonialId)
        {
            return testimonialService.GetTestimonialById(testimonialId);
        }

        [HttpPost]
        [Route("CreateTestimonial")]
        public void CreateTestimonial(Testimonial testimonial)
        {
            testimonialService.CreateTestimonial(testimonial);
        }

        [HttpPut]
        [Route("UpdateTestimonial")]
        public void UpdateTestimonial(Testimonial testimonial)
        {
            testimonialService.UpdateTestimonial(testimonial);
        }

        [HttpDelete]
        [Route("DeleteTestimonial/{testimonialId}")]
        public void DeleteTestimonial(int testimonialId)
        {
            testimonialService.DeleteTestimonial(testimonialId);
        }

        [HttpPut]
        [Route("UpdateTestimonialStatus/{testimonialId}/{newStatus}")]
        public void UpdateTestimonialStatus(int testimonialId, string newStatus)
        {
            testimonialService.UpdateTestimonialStatus(testimonialId, newStatus);
        }
    }
}
