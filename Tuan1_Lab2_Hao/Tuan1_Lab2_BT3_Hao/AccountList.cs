using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Tuan1_Lab2_BT3_Hao
{
    internal class AccountList
    {
        private ArrayList list = new ArrayList();
        public void AddNew()
        {
            Console.Write("Input amount account you needs to add: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Account {0}", i + 1);
                Account a = new Account();
                a.FillInFo();
                list.Add(a);
            }
        }

        public void ListAccount()
        {
            foreach(Account a in list)
            {
                a.Query();
            }    
        }
        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string filename = Console.ReadLine();

            try
            {
                FileStream output = new FileStream(filename,
                    FileMode.CreateNew, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);

                foreach (Account a in list)
                {
                    writer.WriteLine("{0},{1},{2},{3}", a.AccountID ,a.Firstname, a.Lastname, a.Balance);
                }
                writer.Close();
                output.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();

            list.Clear();
            try
            {
                FileStream input = new FileStream(filename,
                    FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);

                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] listt = str.Split(',');

                    Account a = new Account(listt[0],
                        listt[1], listt[2], float.Parse(listt[3]));
                    list.Add(a);
                    a.Query();
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);

            }
        }
        //public void Delete()
        //{
        //    Console.WriteLine("Input file name contains account you need to remove: ");
        //    string filename = Console.ReadLine();
        //    list.Clear();
        //    int d = 0;
        //    try
        //    {
        //        FileStream input = new FileStream(filename,
        //            FileMode.Open, FileAccess.Read);
        //        StreamReader reader = new StreamReader(input);

        //        string str;
        //        Console.WriteLine("Input id of account you need to remove");
        //        string id = Console.ReadLine();
        //        string[] lit;
        //        while((str=reader.ReadLine())!=null)

        //        {

        //            lit = str.Split(',');
        //            Account a = new Account(int.Parse(lit[0]),
        //                lit[1], lit[2], float.Parse(lit[3]));
        //            list.Add(a);
        //            if (lit[0]==id)
        //            {
        //                list.Remove(a);
        //                d++;
        //            }    
        //        }    
        //        reader.Close();
        //        input.Close();
        //    }catch(IOException ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //    if(d==0)
        //    {
        //        Console.WriteLine("Account does not exit!!!");
        //    }
        //    else
        //    {
        //        FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write);
        //        StreamWriter writer = new StreamWriter(output); 
        //        foreach(Account a in list)
        //        {
        //            writer.WriteLine("{0} , {1} , {2} , {3}", a.AccountID, a.Lastname, a.Firstname, a.Balance);

        //        }
        //        writer.Close();
        //        output.Close();
        //        Console.WriteLine("Successfuly deleted the file");
        //    }

        //}
        public void delete()
        {
            Console.Write("Input file name contain account you need to remove: ");
            string filename = Console.ReadLine();
            list.Clear();
            int d = 0;
            try
            {
                FileStream input = new FileStream(filename,
                     FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                Console.Write("Input AccountID you need to remove: ");
                string id = Console.ReadLine();
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] listt = str.Split(',');

                    Account a = new Account(listt[0], listt[1], listt[2], float.Parse(listt[3]));
                    list.Add(a);
                    //if (String.Compare( listt[0],id,true)==0)
                    //{
                    //    list.Remove(a);
                    //    d++;
                    //}
                    if (listt[0]==id)
                    {
                        list.Remove(a);
                        d++;
                    }
                }
                reader.Close();
                input.Close();
            }
            catch (IOException ex)
            {
                Console.Write(ex.Message);
            }
            if (d == 0)
            {
                Console.WriteLine("Ko ton tai account");
                return;
            }
            else
            {
                FileStream output = new FileStream(filename, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Account a in list)
                {



                    writer.WriteLine("{0},{1},{2},{3}", a.AccountID, a.Firstname, a.Lastname, a.Balance);

                }
                writer.Close();
                output.Close();
                Console.WriteLine("=============== Da xoa account thanh cong ============");
            }

        }
        public void SortByID()
        {
            list.Sort(new ComparerAccountID());
        }
        public void SortByName()
        {
            list.Sort(new ComparerAccountName());
        }
        public void SortByBalance()
        {
            list.Sort(new ComparerAccountBalance());
        }

    }
}