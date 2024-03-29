using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusMart_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialPageController : ControllerBase
    {
        private readonly ITestimonialPageService testimonialPageService;

        public TestimonialPageController(ITestimonialPageService testimonialPageService)
        {
            this.testimonialPageService = testimonialPageService;
        }

        [HttpGet]
        [Route("GetAllTestimonialPages")]
        public List<Testimonialpage> GetAllTestimonialPages()
        {
            return testimonialPageService.GetAllTestimonialPages();
        }

        [HttpGet]
        [Route("GetTestimonialPageById/{testimonialPageId}")]
        public Testimonialpage GetTestimonialPageById(int testimonialPageId)
        {
            return testimonialPageService.GetTestimonialPageById(testimonialPageId);
        }

        [HttpPost]
        [Route("CreateTestimonialPage")]
        public void CreateTestimonialPage(Testimonialpage testimonialPage)
        {
            testimonialPageService.CreateTestimonialPage(testimonialPage);
        }

        [HttpPut]
        [Route("UpdateTestimonialPage")]
        public void UpdateTestimonialPage(Testimonialpage testimonialPage)
        {
            testimonialPageService.UpdateTestimonialPage(testimonialPage);
        }

        [HttpDelete]
        [Route("DeleteTestimonialPage/{testimonialPageId}")]
        public void DeleteTestimonialPage(int testimonialPageId)
        {
            testimonialPageService.DeleteTestimonialPage(testimonialPageId);
        }
    }
}
