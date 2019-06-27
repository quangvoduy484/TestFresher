using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePorject.Models
{
    [Table("Movies")]
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public ICollection<MovieDetails> MovieDetails { get; set; }
    }
}
