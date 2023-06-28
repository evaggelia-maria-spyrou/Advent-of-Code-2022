using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FourthChallenge
{
     class CheckSubset
    {
        public int[] SplitAndSpead(string element)
        {
            var arr1 = element.Split("-");
            int start = int.Parse(arr1[0]);
            int end = int.Parse(arr1[1]);
            int length = end - start + 1;
            int[] arr2 = new int[length];
            for(int i=0; i<length; i++)
            {
                arr2[i] = start + i;
            }
            return arr2;
        }


        public bool IsSubset(string element1, string element2,bool issubet=true)
        {
            int[] arr1 = SplitAndSpead(element1);
            int[] arr2 = SplitAndSpead(element2);
            if (issubet)
            {

                bool isSubsetarr1 = arr1.All(e => arr2.Contains(e));
                bool isSubsetarr2 = arr2.All(e => arr1.Contains(e));

                return isSubsetarr1 || isSubsetarr2;

            }
            else
            {
                bool isSubsetarr1 = arr1.Any(e => arr2.Contains(e));
                bool isSubsetarr2 = arr2.Any(e => arr1.Contains(e));

                return isSubsetarr1 || isSubsetarr2;

            }

        }
     
    }
}
