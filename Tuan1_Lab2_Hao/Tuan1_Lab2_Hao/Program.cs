using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_Hao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListBook b1 = new ListBook();
            b1.InputList();
            b1.ShowList();
            Console.WriteLine("-----------Sort Multiple---------------");
            b1.SortMultiple();
            b1.ShowList();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
