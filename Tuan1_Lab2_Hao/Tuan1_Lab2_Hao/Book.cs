using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab2_Hao
{
    class Book : IBook
    {
        private string isbn;
        private string title;
        private string author;
        private string pulisher;
        private int year;

        private ArrayList chapter = new ArrayList();




        public string ISBN { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Pulisher { get => pulisher; set => pulisher = value; }
        public int Year { get => year; set => year = value; }


        public Book()
        {
        }

        public Book(string isbn, string title, string author, string pulisher, int year)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.pulisher = pulisher;
            this.year = year;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }


        public void Output()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Pulisher: " + pulisher);
            Console.WriteLine("Isbn: " + isbn);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0} : {1}", i + 1, chapter[i]);
            Console.WriteLine("--------------------------");

        }
        public void Input()
        {
            Console.Write("Enter Title: ");
            title = Console.ReadLine();
            Console.Write("Enter Author: ");
            author = Console.ReadLine();
            Console.Write("Enter Pulisher: ");
            pulisher = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Enter Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Input chapter (fishned with empty string): ");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);

            } while (str.Length > 0);

        }



    }

}
