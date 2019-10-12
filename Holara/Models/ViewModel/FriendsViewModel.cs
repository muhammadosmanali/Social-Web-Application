using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Holara.Models.ViewModel
{
    public class FriendsViewModel
    {
        public IEnumerable<Friends> friends { get; set; }
        public ApplicationUser applicationUser { get; set; }
    }
}
