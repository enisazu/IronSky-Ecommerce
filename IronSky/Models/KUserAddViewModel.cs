using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IronSky.Models
{
    public class KUserAddViewModel
    {
        [Required(ErrorMessage = "Lütfen Email Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Password Giriniz")]
        public string Password { get; set; }
      
    }
}
