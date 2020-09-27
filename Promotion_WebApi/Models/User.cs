using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion_WebApi.Models
{
    public class User
    {
        [Required]
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public string PhoneNumber { get; set; }
    }
}
