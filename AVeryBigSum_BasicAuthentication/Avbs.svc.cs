using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AVeryBigSum
{
    public class Avbs : IAvbs
    {
        public long AVeryBS(long[] ar)
        {
            long aVeryBigSum = 0;

            foreach (long i in ar) aVeryBigSum += i;
            
            return aVeryBigSum;
        }
    }
}
