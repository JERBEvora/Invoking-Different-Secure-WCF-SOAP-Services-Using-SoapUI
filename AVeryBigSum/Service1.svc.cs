using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AVeryBigSum
{
    public class Service1 : IService1
    {
        public long AVeryBigSum(long[] ar)
        {
            long aVeryBigSum = 0;

            foreach (long i in ar) aVeryBigSum += i;
            
            return aVeryBigSum;
        }
    }
}
