using Microsoft.Extensions.Configuration;
using Promotion_WebApi.Models;
using System.Threading.Tasks;

namespace Promotion_WebApi
{
    public class ProcessData : IProcessData
    {
        private IConfiguration _configuration;

        public ProcessData(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task Process(User user)
        {
            //using (var userMessageContext =
            //    new UserMessageContext(
            //        _configuration.GetConnectionString("DefaultConnection")))
            //{
            //    await userMessageContext.AddAsync(new User
            //    {
            //        UserName = user.UserName,
            //        EmailID = user.EmailID,
            //        PhoneNumber = user.PhoneNumber,
            //        // Created = DateTime.UtcNow
            //    });
            //    await userMessageContext.SaveChangesAsync();
           // }
        }
    }
}