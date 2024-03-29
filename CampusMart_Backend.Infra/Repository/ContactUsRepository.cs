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
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IDbContext dbContext;

        public ContactUsRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Contactu> GetAllContacts()
        {
            IEnumerable<Contactu> result = dbContext.Connection.Query<Contactu>("ContactUs_Package.GetAllContacts", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Contactu GetContactById(int contactId)
        {
            var p = new DynamicParameters();
            p.Add("contact_id_param", contactId, DbType.Int32, ParameterDirection.Input);
            var result = dbContext.Connection.QueryFirstOrDefault<Contactu>("ContactUs_Package.GetContactById", p, commandType: CommandType.StoredProcedure);

            return result;
        }

        public void CreateContact(Contactu contact)
        {
            var p = new DynamicParameters();
            p.Add("fullname_param", contact.Fullname, DbType.String, ParameterDirection.Input);
            p.Add("email_param", contact.Email, DbType.String, ParameterDirection.Input);
            p.Add("phone_param", contact.PhoneNumber, DbType.String, ParameterDirection.Input);
            p.Add("subject_param", contact.Subject, DbType.String, ParameterDirection.Input);
            p.Add("message_param", contact.Message, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("ContactUs_Package.CreateContact", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateContact(Contactu contact)
        {
            var p = new DynamicParameters();
            p.Add("contact_id_param", contact.ContactusId, DbType.Int32, ParameterDirection.Input);
            p.Add("fullname_param", contact.Fullname, DbType.String, ParameterDirection.Input);
            p.Add("email_param", contact.Email, DbType.String, ParameterDirection.Input);
            p.Add("phone_param", contact.PhoneNumber, DbType.String, ParameterDirection.Input);
            p.Add("subject_param", contact.Subject, DbType.String, ParameterDirection.Input);
            p.Add("message_param", contact.Message, DbType.String, ParameterDirection.Input);
            dbContext.Connection.Execute("ContactUs_Package.UpdateContact", p, commandType: CommandType.StoredProcedure);
        }

        public void DeleteContact(int contactId)
        {
            var p = new DynamicParameters();
            p.Add("contact_id_param", contactId, DbType.Int32, ParameterDirection.Input);
            dbContext.Connection.Execute("ContactUs_Package.DeleteContact", p, commandType: CommandType.StoredProcedure);
        }
    }
}
