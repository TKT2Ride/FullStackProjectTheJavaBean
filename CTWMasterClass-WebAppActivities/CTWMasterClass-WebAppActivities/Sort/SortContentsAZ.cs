using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Sort
{
    public class SortContentsAZ: IComparer<Barrel>
    {
        public int Compare(Barrel x, Barrel y)
        {
            var contentsResult = x.contents.CompareTo(y.contents);
            return contentsResult;
        }
    }
}