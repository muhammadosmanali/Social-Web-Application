using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Holara.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string Image { get; set; }

        [Display(Name = "Profile Creation Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime CreatedDate { get; set; }

        public bool IsLogedInOrNot { get; set; }
    }
}
