﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace muscshop.Models
{
    public class Album
    {
        Required(ErrorMessage = "enter the title")]
        public string Title { get; set; }
        [Range(1, 300, ErrorMessage = "enter price: 1 to 300")]
        public double Price { get; set; }
        [Display(Name = "Photo URL")]
        public string AlbumUrl { get; set; }
        [Required(ErrorMessage = "ReleaseYear is required")]
        [Display(Name = "Release Year")]
        [Range(1960, 2020, ErrorMessage = "enter year: 1960 to 2020")]
        public int ReleaseYear { get; set; }
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public int AlbumId { get; set; }
        [MaxLength(100, ErrorMessage = "Max 100 symbols")]
        public string Description { get; set; } = "albumDescription";
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public Album()
        {
            AlbumUrl = "~/App_Files/Images/default.png";
        }
    }
}