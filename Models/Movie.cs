﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ASPTute_Vidly.Models;
using ASPTute_Vidly.Models.Validation;

namespace ASPVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [DisplayName("Number In Stock")]
        [Range(1,20)]
        public byte NumInStock { get; set; }

        public Genre Genre { get; set; }

        [DisplayName("Genre")]
        public byte GenreId { get; set; }
    }
}