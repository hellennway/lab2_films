using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using films.Models;
using System.Linq;
using System.Threading.Tasks;

namespace films.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        [Required(ErrorMessage = "Потрібно заповнити поле")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Довжина значення від 2 до 50 символів")]
        [Display(Name = "Назва країни")]
        public string Name { get; set; }

        public virtual ICollection<Artist> Artist { get; set; }
        public virtual ICollection<Film> Film { get; set; }
    }
}
