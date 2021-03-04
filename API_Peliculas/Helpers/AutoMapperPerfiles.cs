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
            //Mapper entidad Genero
            CreateMap<Genero, GeneroDTO>().ReverseMap();
            CreateMap<GeneroCreacionDTO, Genero>();

            //Mapper entidad Actor
            CreateMap<Actor, ActorDTO>().ReverseMap();
            CreateMap<ActorCreacionDTO, Actor>();
        }
    }
}
