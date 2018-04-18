using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class TeamPosition
    {
        public string eventId { get; set; }
        public string TeamId { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string ptStpPass { get; set; }
    }
}
