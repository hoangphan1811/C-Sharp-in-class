using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_BT3_Hao
{
    internal class Account
    {
        string accountID;
        string firstname;
        string lastname;
        float balance;


        public Account()
        {
            accountID = "";
            firstname = "";
            lastname = "";
            balance = 0;
        }
        public Account(string accountID, string firstname, string lastname, float balance)
        {
            this.AccountID = accountID;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Balance = balance;
        }

    

        public string AccountID { get => accountID; set => accountID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public float Balance { get => balance; set => balance = value; }
        public void FillInFo()
        {
            Console.Write("Enter Account ID: ");
            accountID = Console.ReadLine();
            Console.Write("Enter First Name: ");
            firstname = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            lastname = Console.ReadLine();
            Console.Write("Enter Balance: ");
            balance = float.Parse(Console.ReadLine());
            Console.WriteLine();

        }
        public void Query()
        {
            /* Console.WriteLine("Account ID: " + accountID);
             Console.WriteLine("First Name: " + firstname);
             Console.WriteLine("Last Name: " + lastname);
             Console.WriteLine("Balance: "+ balance);*/
            Console.WriteLine("Account:{0}   FirstName:{1}   LastName:{2}   Balance:{3}", accountID, firstname, lastname, balance);

            Console.WriteLine();

        }
    }
}
