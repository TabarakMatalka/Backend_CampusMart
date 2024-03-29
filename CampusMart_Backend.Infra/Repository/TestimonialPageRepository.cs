using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Data;
using CampusMart_Backend.Core.Repository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusMart_Backend.Infra.Repository
{
    public class TestimonialPageRepository : ITestimonialPageRepository
    {
        private readonly IDbContext dbContext;

        public TestimonialPageRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Testimonialpage> GetAllTestimonialPages()
        {
            IEnumerable<Testimonialpage> result = dbContext.Connection.Query<Testimonialpage>("TestimonialPage_Package.GetAllTestimonialPages", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testimonialpage GetTestimonialPageById(int testimonialPageId)
        {
            var p = new DynamicParameters();
            p.Add("tp_TestimonialPage_ID", testimonialPageId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Testimonialpage>("TestimonialPage_Package.GetTestimonialPageByID", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateTestimonialPage(Testimonialpage testimonialPage)
        {
            var p = new DynamicParameters();
            p.Add("tp_TITLE", testimonialPage.Title, DbType.String, ParameterDirection.Input);
            p.Add("tp_HEADER_COMPONENT1", testimonialPage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("tp_HEADER_COMPONENT2", testimonialPage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("tp_HEADER_COMPONENT3", testimonialPage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("tp_PARAGRAPH1", testimonialPage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("tp_PARAGRAPH2", testimonialPage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("tp_PARAGRAPH3", testimonialPage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("tp_FOOTER_COMPONENT1", testimonialPage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("tp_FOOTER_COMPONENT2", testimonialPage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("tp_FOOTER_COMPONENT3", testimonialPage.FooterComponent3, DbType.String, ParameterDirection.Input);
            p.Add("tp_IMAGE_PATH1", testimonialPage.ImagePath1, DbType.String, ParameterDirection.Input);
            p.Add("tp_IMAGE_PATH2", testimonialPage.ImagePath2, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("TestimonialPage_Package.Create_TestimonialPage", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateTestimonialPage(Testimonialpage testimonialPage)
        {
            var p = new DynamicParameters();
            p.Add("tp_TestimonialPage_ID", testimonialPage.TestimonialpageId, DbType.Int32, ParameterDirection.Input);
            p.Add("tp_TITLE", testimonialPage.Title, DbType.String, ParameterDirection.Input);
            p.Add("tp_HEADER_COMPONENT1", testimonialPage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("tp_HEADER_COMPONENT2", testimonialPage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("tp_HEADER_COMPONENT3", testimonialPage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("tp_PARAGRAPH1", testimonialPage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("tp_PARAGRAPH2", testimonialPage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("tp_PARAGRAPH3", testimonialPage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("tp_FOOTER_COMPONENT1", testimonialPage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("tp_FOOTER_COMPONENT2", testimonialPage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("tp_FOOTER_COMPONENT3", testimonialPage.FooterComponent3, DbType.String, ParameterDirection.Input);
            p.Add("tp_IMAGE_PATH1", testimonialPage.ImagePath1, DbType.String, ParameterDirection.Input);
            p.Add("tp_IMAGE_PATH2", testimonialPage.ImagePath2, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("TestimonialPage_Package.Update_TestimonialPage", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTestimonialPage(int testimonialPageId)
        {
            var p = new DynamicParameters();
            p.Add("tp_TestimonialPage_ID", testimonialPageId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("TestimonialPage_Package.DeleteTestimonialPage", p, commandType: CommandType.StoredProcedure);
        }
    }
}
