using Promotion_WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promotion_WebApi
{
    public interface IProcessData
    {
        Task Process(User user);
    }
}
