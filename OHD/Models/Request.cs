using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public DateTime Time { get; set; }
        public string Detail { get; set; }
        public enum Status { done,working }

        public Status UpdateStatus { get; set; }
    }
}
