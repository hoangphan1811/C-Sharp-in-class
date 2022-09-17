using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_BT3_Hao
{
    internal class ComparerAccountName : IComparer
    {
        public int Compare(object a, object b)
        {
            Account a1 = (Account)a;
            Account b1 = (Account)b;
            return a1.Firstname.CompareTo(b1.Firstname);    
        }
    }
}
