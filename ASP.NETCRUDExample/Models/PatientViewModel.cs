using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCRUDExample.Models
{

    public class PatientViewModel
    {
        [Required]
        [Display(Name = "Name: ")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Address: ")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "TAJ: ")]
        public string PatientNbr { get; set; }

        [Required]
        [Display(Name = "Phone: ")]
        public string PhoneNbr { get; set; }

        [Required]
        [Display(Name = "E-mail: ")]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(Email))]
        [Display(Name = "Confirm E-mail: ")]
        public string EmailConfirm { get; set; }

        [Required]
        [Display(Name = "Gender: ")]
        public int Gender { get; set; }

        public Dictionary<string, int> Genders { get => GetGenders();  }

        public static Dictionary<string, int> GetGenders()
        {
            return new Dictionary<string, int>()
            {
                 {"Male", 0 },
                {"Female", 1 },
                {"Other", 2 }
            };
        }
    }
}
