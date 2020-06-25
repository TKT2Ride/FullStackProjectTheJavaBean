using CTWMasterClass_WebAppActivities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Sort
{
    public class WeightHL : IComparer<Barrel>
    {
        public int Compare(Barrel x, Barrel y)
        {
            if (x.Weight > y.Weight)
            {
                return -1;
            }
            else if (x.Weight < y.Weight)
            {
                return 1;
            }
            return 0;
        }
    }
}