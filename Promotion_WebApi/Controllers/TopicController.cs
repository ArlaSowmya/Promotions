using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Promotion_WebApi.Models;
using Promotion_WebApi.Services;

namespace Promotion_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly TopicSender _TopicSender;

        public TopicController(TopicSender TopicSender)
        {
            _TopicSender = TopicSender;
        }
        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(User), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> Create([FromBody][Required] User request)
        {
            if (data.Any(d => d.UserName == request.UserName))
            {
                return Conflict($"data with UserName {request.UserName} already exists");
            }

            data.Add(request);

            // Send this to the bus for the other services
            await _TopicSender.SendMessage(new User
            {
                UserName = request.UserName,
                EmailID = request.EmailID,
                PhoneNumber = request.PhoneNumber,
            });

            return Ok(request);
        }
        private static readonly List<User> data = new List<User>
        {
            new User{ UserName="Sowmya", EmailID="sow@gmail.com", PhoneNumber="9223322331"},
            new User{ UserName="Guna", EmailID="guna@gmail.com", PhoneNumber="9297867432"},
        };
    }
}
