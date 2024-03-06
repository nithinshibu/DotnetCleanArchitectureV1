﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Mappers;

public class MovieMapper
{
    private static readonly Lazy<IMapper> Lazy = new(() =>
    {
        var config = new MapperConfiguration(cgf =>
        {
            cgf.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
            cgf.AddProfile<MovieMappingProfile>();
        });

        var mapper = config.CreateMapper();
        return mapper;

    });

    public static IMapper Mapper => Lazy.Value;
}

