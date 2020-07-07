
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Models
{
    public class ViewModel
    {
        public IEnumerable<Barrel> Barrels { get; set; }
        public IEnumerable<Cube> Cubes { get; set; }
    }
}