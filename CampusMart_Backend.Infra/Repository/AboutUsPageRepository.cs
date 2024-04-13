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
    public class AboutUsPageRepository : IAboutUsPageRepository
    {
       private readonly IDbContext dbContext;

        public AboutUsPageRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Aboutuspage> GetAllAboutUsPages()
        {
            IEnumerable<Aboutuspage> result = dbContext.Connection.Query<Aboutuspage>("AboutUsPagePackage.GetAllAboutUsPages", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Aboutuspage GetAboutUsPageById(int pageId)
        {
            var p = new DynamicParameters();
            p.Add("page_id", pageId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Aboutuspage>("AboutUsPagePackage.GetAboutUsPageById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateAboutUsPage(Aboutuspage aboutUsPage)
        {
            var p = new DynamicParameters();
            p.Add("logo_path_param", aboutUsPage.LogoPath, DbType.String, ParameterDirection.Input);
            p.Add("header_component1_param", aboutUsPage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("header_component2_param", aboutUsPage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("header_component3_param", aboutUsPage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("paragraph1_param", aboutUsPage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("paragraph2_param", aboutUsPage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("paragraph3_param", aboutUsPage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("footer_component1_param", aboutUsPage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("footer_component2_param", aboutUsPage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("footer_component3_param", aboutUsPage.FooterComponent3, DbType.String, ParameterDirection.Input);
            p.Add("image_path1_param", aboutUsPage.ImagePath1, DbType.String, ParameterDirection.Input);
            p.Add("image_path2_param", aboutUsPage.ImagePath2, DbType.String, ParameterDirection.Input);
            
            dbContext.Connection.Execute("AboutUsPagePackage.CreateAboutUsPage", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateAboutUsPage(Aboutuspage aboutUsPage)
        {
            var p = new DynamicParameters();
            p.Add("page_id_param", aboutUsPage.AboutuspageId, DbType.Int32, ParameterDirection.Input);
            p.Add("logo_path_param", aboutUsPage.LogoPath, DbType.String, ParameterDirection.Input);
            p.Add("header_component1_param", aboutUsPage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("header_component2_param", aboutUsPage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("header_component3_param", aboutUsPage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("paragraph1_param", aboutUsPage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("paragraph2_param", aboutUsPage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("paragraph3_param", aboutUsPage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("footer_component1_param", aboutUsPage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("footer_component2_param", aboutUsPage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("footer_component3_param", aboutUsPage.FooterComponent3, DbType.String, ParameterDirection.Input);
            p.Add("image_path1_param", aboutUsPage.ImagePath1, DbType.String, ParameterDirection.Input);
            p.Add("image_path2_param", aboutUsPage.ImagePath2, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("AboutUsPagePackage.UpdateAboutUsPage", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteAboutUsPage(int pageId)
        {
            var p = new DynamicParameters();
            p.Add("page_id_param", pageId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("AboutUsPagePackage.DeleteAboutUsPage", p, commandType: CommandType.StoredProcedure);
        }
    }
}
