using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models.ViewModel
{
    public class UserViewModel
    {
        public IEnumerable<Facility> Facilities { get; set; }
        public IEnumerable<Request> Requests { get; set; }
        public PageInfo PageInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}
