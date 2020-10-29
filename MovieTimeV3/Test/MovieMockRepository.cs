using Microsoft.AspNetCore.Hosting;
using MovieTimeV3.Data;
using MovieTimeV3.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTimeV3.Test
{
    public class MovieMockRepository //: IMovieRepository
    {
        string basePath;
        public MovieMockRepository(IWebHostEnvironment webHostEnvironment)
        {
            basePath = $"{webHostEnvironment.ContentRootPath}\\Test\\Mockdata\\";
        }


        public async Task<MovieDetailsDto> GetMovie()
        {
            string testFile = "movie.json";
            var result = GetTestData<MovieDetailsDto>(testFile);
            await Task.Delay(0);
            return result;
        }

        private T GetTestData<T>(string testFile)
        {
            string path = $"{basePath}{testFile}";
            string data = File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<T>(data);
            return result;
        }
    }
}
