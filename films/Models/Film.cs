using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using films.Models;
using System.Linq;
using System.Threading.Tasks;

namespace films.Models
{
    public class Film
    {
        public Film()
        {
            FilmGenre = new List<FilmGenre>();
        }

        public int FilmId { get; set; }
        [Required(ErrorMessage = "Потрібно заповнити поле")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина значення від 2 до 50 символів")]
        [Display(Name = "Назва фільму")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Потрібно заповнити поле")]
        [Range(1600, 2020, ErrorMessage = "Введіть від 1600 до поточного")]
        [Display(Name = "Рік виходу")]
        public int Year { get; set; }

        [Display(Name = "Режисер")]
        public int DirectorId { get; set; }

        [Display(Name = "Країна")]
        public int CountryId { get; set; }

        [Display(Name = "Опис фільму")]
        public string Description { get; set; }

        [Display(Name = "Країна")]
        public virtual Country Country { get; set; }
        [Display(Name = "Режисер")]
        public virtual Director Director { get; set; }
        public virtual ICollection<FilmGenre> FilmGenre { get; set; }
    }
}
