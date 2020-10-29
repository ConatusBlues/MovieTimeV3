using MovieTimeV3.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTimeV3.Data
{
    public interface IMovieRepository
    {
        Task<MovieDto> GetMovie();
        Task<IEnumerable<MovieDto>> GetMovies();

    }
}
