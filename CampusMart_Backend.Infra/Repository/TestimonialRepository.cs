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


    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbContext dbContext;

        public TestimonialRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Testimonial> GetAllTestimonials()
        {
            IEnumerable<Testimonial> result = dbContext.Connection.Query<Testimonial>("Testimonial_Package.GetAllTestimonials", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testimonial GetTestimonialById(int testimonialId)
        {
            var p = new DynamicParameters();
            p.Add("testimonial_id_param", testimonialId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Testimonial>("Testimonial_Package.GetTestimonialById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("testimonial_text_param", testimonial.Testimonialtext, DbType.String, ParameterDirection.Input);
            p.Add("status_param", testimonial.Status, DbType.String, ParameterDirection.Input);
            p.Add("consumer_id_param", testimonial.Consumerid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Testimonial_Package.CreateTestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("testimonial_id_param", testimonial.Testimonialid, DbType.Int32, ParameterDirection.Input);
            p.Add("testimonial_text_param", testimonial.Testimonialtext, DbType.String, ParameterDirection.Input);
            p.Add("status_param", testimonial.Status, DbType.String, ParameterDirection.Input);
            p.Add("consumer_id_param", testimonial.Consumerid, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Testimonial_Package.UpdateTestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteTestimonial(int testimonialId)
        {
            var p = new DynamicParameters();
            p.Add("testimonial_id_param", testimonialId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("Testimonial_Package.DeleteTestimonial", p, commandType: CommandType.StoredProcedure);
        }
    }

}
