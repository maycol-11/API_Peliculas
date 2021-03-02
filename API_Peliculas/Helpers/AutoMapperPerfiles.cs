using API_Peliculas.DTOs;
using API_Peliculas.Entidades;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Peliculas.Helpers
{
    public class AutoMapperPerfiles : Profile
    {
        public AutoMapperPerfiles()
        {
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();
        }
    }
}
