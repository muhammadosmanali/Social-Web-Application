using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Holara.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Post")]
        public string PostDescription { get; set; }

        [Display(Name = "Public")]
        public bool IsPublicOrNot { get; set; }

        public string Image { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        public DateTime PostDateAndTime { get; set; }

        public bool Hide { get; set; }
    }
}
