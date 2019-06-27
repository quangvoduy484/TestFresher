﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePorject.Models
{
    [Table("Persons")]
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public ICollection<MovieDetails> MovieDetails { get; set; }
    }
}
