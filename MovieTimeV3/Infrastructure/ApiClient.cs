﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MovieTimeV3.Infrastructure
{
    public class ApiClient : IApiClient
    {
        public async Task<T> GetAsync<T>(string endpoint)
        {
            //TODO: Fixa så att koden inte upprep
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(data);
                return result;
            }
        }
    }
}
