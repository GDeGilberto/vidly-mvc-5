
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genero")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Numero de Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}