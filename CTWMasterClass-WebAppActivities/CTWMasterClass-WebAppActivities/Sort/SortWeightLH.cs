using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Sort
{
    public class SortWeightLH: IComparer<Barrel>
    {
        public int Compare(Barrel x, Barrel y)
        {
            return x.weight-y.weight;
        }
    }
}