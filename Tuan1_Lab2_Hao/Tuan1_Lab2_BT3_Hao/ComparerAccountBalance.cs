using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_BT3_Hao
{
    internal class ComparerAccountBalance : IComparer
    {
        public int Compare(object c, object d )
        {
             Account c1= (Account)c;
            Account d1= (Account)d;
            return c1.Balance.CompareTo( d1.Balance );
        }
    }
}
