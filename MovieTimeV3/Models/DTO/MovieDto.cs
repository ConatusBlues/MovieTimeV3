using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTimeV3.Models.DTO
{
    public class MovieDto
    {
        //public MovieDetailsDto Movie { get; set; }
        public IEnumerable<MovieDetailsDto> Movie { get; set; }
    }
}
