using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTimeV3.Models.DTO;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MovieTimeV3.Data
{
    public class MovieRepository : IMovieRepository
    {
        //baseURL = open movie database bashemsideadress
        //pluss på detta med film-id och api-nyckel så får man info sen
        private string baseURL;
        //  Loves API-nyckel
        private string apiKey = "&apikey=14521613";
        public MovieRepository(IConfiguration configuration)
        {
            baseURL = configuration.GetValue<string>("OmdbAPI:BaseUrl");
        }
        public async Task<IEnumerable<MovieDto>> GetMovies()
        {
            using (HttpClient client = new HttpClient())
            {
                //tt3896198 = imdb-nyckel - BYT MOT SÖKQUERY SEN men behåll ?i=
                //min test-apinyckel http://www.omdbapi.com/?i=tt3896198&apikey=14521613
                string endpoint = $"{baseURL}?i=tt3896198{apiKey}";
                var response = await client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);
                response.EnsureSuccessStatusCode();
                var data = await response.Content.ReadAsStringAsync();
                //konverterar Json-objekt till läsbara data
                var result = JsonConvert.DeserializeObject<IEnumerable<MovieDto>>(data);
                return result;
            }

        }

    }
}
