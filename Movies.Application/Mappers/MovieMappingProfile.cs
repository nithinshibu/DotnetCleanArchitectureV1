﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Movies.Application.Commands;
using Movies.Application.Responses;
using Movies.Core.Entities;

namespace Movies.Application.Mappers
{
    public class MovieMappingProfile:Profile
    {
        public MovieMappingProfile()
        {
            CreateMap<Movie, MovieResponse>().ReverseMap();
            CreateMap<Movie,CreateMovieCommand>().ReverseMap();
        }
    }
}
