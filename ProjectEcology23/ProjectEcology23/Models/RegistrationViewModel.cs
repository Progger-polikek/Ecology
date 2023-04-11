using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEcology23.Models
{
    public class RegistrationViewModel
    {
        [Display(Name = "Фамилия")]
        public string sname { get; set; }

        [Display(Name = "Имя")]
        public string name { get; set; }

        [Display(Name = "Отчество")]
        public string pname { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "log")]
        public string logname { get; set; }

        [Display(Name = "pass")]
        public string pass { get; set; }

        [Display(Name = "pass2")]
        public string pass2 { get; set; }
    }
}
