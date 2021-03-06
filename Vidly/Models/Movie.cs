﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        public int NumberInStock { get; set; }

    }
}