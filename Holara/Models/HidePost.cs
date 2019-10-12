using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Holara.Models
{
    public class HidePost
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser applicationUser { get; set; }

        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public Post post { get; set; }
    }
}
