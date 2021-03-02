using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API_Peliculas.DTOs
{
    public class GeneroDTO :GeneroCreacionDTO
    {
        public int Id { get; set; }
       
    }
}
