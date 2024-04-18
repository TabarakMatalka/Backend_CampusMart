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
    public class HomePageRepository : IHomePageRepository
    {
       private readonly IDbContext dbContext;

        public HomePageRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Homepage> GetAllHomePages()
        {
            IEnumerable<Homepage> result = dbContext.Connection.Query<Homepage>("HomePage_Package.GetAllHomePages", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Homepage GetHomePageById(int homePageId)
        {
            var p = new DynamicParameters();
            p.Add("HOMEPAGE_ID_param", homePageId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Homepage>("HomePage_Package.GetHomePageByID", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateHomePage(Homepage homePage)
        {
            var p = new DynamicParameters();
            p.Add("LOGO_PATH_param", homePage.LogoPath, DbType.String, ParameterDirection.Input);
            p.Add("TITLE_param", homePage.Title, DbType.String, ParameterDirection.Input);
            p.Add("HEADER_COMPONENT1_param", homePage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("HEADER_COMPONENT2_param", homePage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("HEADER_COMPONENT3_param", homePage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPH1_param", homePage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPH2_param", homePage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPH3_param", homePage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("FOOTER_COMPONENT1_param", homePage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("FOOTER_COMPONENT2_param", homePage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("FOOTER_COMPONENT3_param", homePage.FooterComponent3, DbType.String, ParameterDirection.Input);
            p.Add("IMAGE_PATH1_param", homePage.ImagePath1, DbType.String, ParameterDirection.Input);
            p.Add("IMAGE_PATH2_param", homePage.ImagePath2, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("HomePage_Package.Create_HomePage", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateHomePage(Homepage homePage)
        {
            var p = new DynamicParameters();
            p.Add("HOMEPAGE_ID_param", homePage.HomepageId, DbType.Int32, ParameterDirection.Input);
            p.Add("LOGO_PATH_param", homePage.LogoPath, DbType.String, ParameterDirection.Input);
            p.Add("TITLE_param", homePage.Title, DbType.String, ParameterDirection.Input);
            p.Add("HEADER_COMPONENT1_param", homePage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("HEADER_COMPONENT2_param", homePage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("HEADER_COMPONENT3_param", homePage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPH1_param", homePage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPH2_param", homePage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("PARAGRAPH3_param", homePage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("FOOTER_COMPONENT1_param", homePage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("FOOTER_COMPONENT2_param", homePage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("FOOTER_COMPONENT3_param", homePage.FooterComponent3, DbType.String, ParameterDirection.Input);
            p.Add("IMAGE_PATH1_param", homePage.ImagePath1, DbType.String, ParameterDirection.Input);
            p.Add("IMAGE_PATH2_param", homePage.ImagePath2, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("HomePage_Package.Update_HomePage", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteHomePage(int homePageId)
        {
            var p = new DynamicParameters();
            p.Add("HOMEPAGE_ID_param", homePageId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("HomePage_Package.DeleteHomePage", p, commandType: CommandType.StoredProcedure);
        }
    }
}
