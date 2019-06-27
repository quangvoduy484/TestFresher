using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePorject.Models
{
    public class MovieDetails
    {
        public int MovieDetailsId { get; set; }
        public DateTime CreateBy { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie  { get; set; }

        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person  { get; set; }
    }
}
