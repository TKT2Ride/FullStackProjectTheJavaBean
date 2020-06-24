using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Sort
{
    public class SortWeightHL: IComparer<Barrel>
    {
        public int Compare(Barrel x, Barrel y)
        {
            return y.weight - x.weight;
        }
    }
}