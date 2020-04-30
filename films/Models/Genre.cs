using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using films.Models;
using System.Linq;
using System.Threading.Tasks;

namespace films.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Required(ErrorMessage = "Потрібно заповнити поле")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина значення від 2 до 50 символів")]
        [Display(Name = "Назва жанру")]
        public string Name { get; set; }


        public virtual ICollection<FilmGenre> FilmGenre { get; set; }
    }
}
