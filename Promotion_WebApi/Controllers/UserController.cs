using Microsoft.AspNetCore.Mvc;
using Promotion_WebApi.Models;
using Promotion_WebApi.Services;
using System;
using System.Threading.Tasks;

namespace Promotion_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private TopicsAndSubscription a;
        public UserController()
        {
           // a = new TopicsAndSubscription();
        }
        [HttpPost]
        public async Task<IActionResult> PublishCustomer([FromBody] User user)
        {
            var newUser = new User
            {
                UserName = user.UserName,
                EmailID = user.EmailID,
                PhoneNumber = user.PhoneNumber
            };
            Console.WriteLine(newUser.ToString());
            //await a.TopicsAndSubscriptionTask(newUser);
            return Ok();
        }
    }

}
