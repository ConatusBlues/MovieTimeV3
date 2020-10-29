﻿using MovieTimeV3.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTimeV3.Data
{
    public interface IMovieRepository
    {

        Task<IEnumerable<MovieDto>> GetMovie();
        //Task<MovieDetailsDto> GetMovie();
        //Task<MovieDto> GetMovie();

    }
}
