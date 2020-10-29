using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTimeV3.Infrastructure
{
    public interface IApiClient
    {

        Task<T> GetAsync<T>(string endpoint);

    }
}
