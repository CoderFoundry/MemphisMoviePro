using MemphisMovie.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemphisMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public DateTime ReleaseDate { get; set; }
        public MovieRating Rating { get; set; }

        //Poster Properties
        public byte[] Poster { get; set; }
        public string ContentType { get; set; }
    }
}
