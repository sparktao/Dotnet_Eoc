using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MovieGenreViewModel
    {

        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }

    }
}
