using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEcology23.Models
{
    public class PetitionViewModel
    {
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Описание нарушения")]
        public string AboutPetition { get; set; }

        [Display(Name = "Адрес нарушения")]
        public string AddressPetition { get; set; }
    }
}
