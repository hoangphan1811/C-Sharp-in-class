using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_BT3_Hao
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            byte chose;
            do
            {
                Console.WriteLine("=============MENU==============");
                Console.WriteLine("*** 1.Add a Account***");
                Console.WriteLine("*** 2.Save File***");
                Console.WriteLine("*** 3.Load file***");
                Console.WriteLine("*** 4.Delete Account***");
                Console.WriteLine("*** 5.Sort By ID***");
                Console.WriteLine("*** 6.Sort By Name***");
                Console.WriteLine("*** 7.Sort By Balance***");
                Console.WriteLine("** 0.Quit **");
                Console.Write("Select function: ");
                chose = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (chose)
                {
                    case 1:
                        Console.WriteLine("==================ADD A ACCOUNT==================");
                        accountList.AddNew();
                        break;
                    case 2:
                        accountList.SaveFile();
                        break;
                    case 3:
                        accountList.LoadFile();
                        break;
                    case 4:
                        accountList.delete();
                        break;
                    case 5:
                        accountList.SortByID();
                        Console.WriteLine("List account after sort");
                        accountList.ListAccount();
                        break;
                    case 6:
                        accountList.SortByName();
                        Console.WriteLine("List account after sort");
                        accountList.ListAccount();
                        break;
                    case 7:
                        accountList.SortByBalance();
                        Console.WriteLine("List account after sort");
                        accountList.ListAccount();
                        break;
                    default:
                        Console.WriteLine("Please input again");
                        break;
                }

            } while (chose != 0);
        }
    }
}
