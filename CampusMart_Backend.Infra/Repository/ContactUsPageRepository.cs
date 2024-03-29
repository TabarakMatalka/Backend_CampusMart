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
    public class ContactUsPageRepository : IContactUsPageRepository
    {
        private readonly IDbContext dbContext;

        public ContactUsPageRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Contactuspage> GetAllContactUsPages()
        {
            IEnumerable<Contactuspage> result = dbContext.Connection.Query<Contactuspage>("ContactUsPagePackage.GetAllContactUsPages", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Contactuspage GetContactUsPageById(int pageId)
        {
            var p = new DynamicParameters();
            p.Add("page_id", pageId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Contactuspage>("ContactUsPagePackage.GetContactUsPageById", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void CreateContactUsPage(Contactuspage contactUsPage)
        {
            var p = new DynamicParameters();
            p.Add("logo_path_param", contactUsPage.LogoPath, DbType.String, ParameterDirection.Input);
            p.Add("email_param", contactUsPage.Email, DbType.String, ParameterDirection.Input);
            p.Add("subject_param", contactUsPage.Subject, DbType.String, ParameterDirection.Input);
            p.Add("message_param", contactUsPage.Message, DbType.String, ParameterDirection.Input);
            p.Add("header_component1_param", contactUsPage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("header_component2_param", contactUsPage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("header_component3_param", contactUsPage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("paragraph1_param", contactUsPage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("paragraph2_param", contactUsPage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("paragraph3_param", contactUsPage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("footer_component1_param", contactUsPage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("footer_component2_param", contactUsPage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("footer_component3_param", contactUsPage.FooterComponent3, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("ContactUsPagePackage.CreateContactUsPage", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateContactUsPage(Contactuspage contactUsPage)
        {
            var p = new DynamicParameters();
            p.Add("page_id_param", contactUsPage.ContactuspageId, DbType.Int32, ParameterDirection.Input);
            p.Add("logo_path_param", contactUsPage.LogoPath, DbType.String, ParameterDirection.Input);
            p.Add("email_param", contactUsPage.Email, DbType.String, ParameterDirection.Input);
            p.Add("subject_param", contactUsPage.Subject, DbType.String, ParameterDirection.Input);
            p.Add("message_param", contactUsPage.Message, DbType.String, ParameterDirection.Input);
            p.Add("header_component1_param", contactUsPage.HeaderComponent1, DbType.String, ParameterDirection.Input);
            p.Add("header_component2_param", contactUsPage.HeaderComponent2, DbType.String, ParameterDirection.Input);
            p.Add("header_component3_param", contactUsPage.HeaderComponent3, DbType.String, ParameterDirection.Input);
            p.Add("paragraph1_param", contactUsPage.Paragraph1, DbType.String, ParameterDirection.Input);
            p.Add("paragraph2_param", contactUsPage.Paragraph2, DbType.String, ParameterDirection.Input);
            p.Add("paragraph3_param", contactUsPage.Paragraph3, DbType.String, ParameterDirection.Input);
            p.Add("footer_component1_param", contactUsPage.FooterComponent1, DbType.String, ParameterDirection.Input);
            p.Add("footer_component2_param", contactUsPage.FooterComponent2, DbType.String, ParameterDirection.Input);
            p.Add("footer_component3_param", contactUsPage.FooterComponent3, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("ContactUsPagePackage.UpdateContactUsPage", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteContactUsPage(int pageId)
        {
            var p = new DynamicParameters();
            p.Add("page_id_param", pageId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("ContactUsPagePackage.DeleteContactUsPage", p, commandType: CommandType.StoredProcedure);
        }
    }
}
