using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_BT3_Hao
{
    class ComparerAccountID : IComparer
    {
        public int Compare(object x, object y)
        {
            Account x1 = (Account)x;
            Account y1 = (Account)y;
         return x1.AccountID.CompareTo(y1.AccountID);
          

        }



    }
}
