using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using films.Models;
using System.Linq;
using System.Threading.Tasks;

namespace films.Models
{
    public class FilmGenre
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int GenreId { get; set; }
        [Display(Name = "Фільм")]
        public virtual Film Film { get; set; }
        [Display(Name = "Жанр")]
        public virtual Genre Genre { get; set; }
    }
}
