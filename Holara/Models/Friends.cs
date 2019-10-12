using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Holara.Models
{
    public class Friends
    {
        public int Id { get; set; }

        public string User1Id { get; set; }

        public string User2Id { get; set; }

        [ForeignKey("User1Id")]
        public virtual ApplicationUser ApplicationUser1 { get; set; }

        [ForeignKey("User2Id")]
        public virtual ApplicationUser ApplicationUser2 { get; set; }

        public bool IsConfirmed { get; set; }

        public DateTime RequestDate { get; set; }
    }
}
