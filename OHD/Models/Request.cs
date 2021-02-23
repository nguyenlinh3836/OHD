using OHD.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public DateTime Time { get; set; }
        public string Detail { get; set; }
        public String Status { get; set; }
        public int FacilityID { get; set; }
       
        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        [ForeignKey("EmployeeID")]
        public int? EmployeeID { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
