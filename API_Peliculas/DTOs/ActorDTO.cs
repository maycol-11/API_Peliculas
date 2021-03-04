using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Peliculas.DTOs
{
    public class ActorDTO : ActorCreacionDTO
    {
        public int Id { get; set; }
        public string Foto { get; set; }
    }
}
