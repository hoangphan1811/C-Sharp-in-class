using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1_Lab1_Hao
{

    class Student
    {
        List<Student> List = new List<Student>();
        private string studentID;
        private string FullName;
        private float avergeScore;
        private string faculty;

        public Student()
        {
            studentID = "";
            FullName = "";
            avergeScore = 0;
            faculty = "";

        }
        public Student(string studentID, string fullName, float avergeScore, string faculty)
        {
            this.studentID = studentID;
            FullName = fullName;
            this.avergeScore = avergeScore;
            this.faculty = faculty;
        }

        public string StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }

        public string FullName1
        {
            get
            {
                return FullName;
            }

            set
            {
                FullName = value;
            }
        }

        public float AvergeScore
        {
            get
            {
                return avergeScore;
            }

            set
            {
                avergeScore = value;
            }
        }

        public string Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }
        public void Input()
        {
            Console.Write("Enter StudentID: ");
            studentID = Console.ReadLine();
            Console.Write("Enter Student name: ");
            FullName = Console.ReadLine();
            Console.Write("Enter averge score: ");
            avergeScore = float.Parse(Console.ReadLine());
            Console.Write("Enter faculty: ");
            faculty = Console.ReadLine();
        }
        public void Output()
        {/*
            Console.WriteLine(" StudentID: "+studentID);
            Console.WriteLine("Enter Student name: "+FullName);
            Console.WriteLine("Enter averge score: "+avergeScore);
            Console.WriteLine("Enter faculty: "+faculty);
            */
            Console.WriteLine("StudenID:{0}   FullName:{1}   AvergeScore:{2}   Faculty:{3}", studentID, FullName, avergeScore, faculty);
        }
        private static void AddStudent(List<Student> Listt)
        {
            Student temp = new Student();
            temp.Input();
            Listt.Add(temp);
        }
        private static List<Student> EnterListStudent()
        {
            List<Student> ListStudents = new List<Student>();
            Console.Write("Enter number student you needs to add: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n****List STUDENT****\n");
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter student {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                ListStudents.Add(temp);
                Console.WriteLine("\n");
            }
            return ListStudents;
        }

        private static void ShowListStudent(List<Student> ListStudents)
        {

            foreach (Student stu in ListStudents)
            {
                stu.Output();
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            List<Student> List = new List<Student>();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int n;
            byte chose;
            do
            {
                Console.WriteLine("\nSTUDENT MANAGEMENT PROGRAM");
                Console.WriteLine("*********************************MENU**************************************");
                Console.WriteLine("** 1.Enter list student                                                  **");
                Console.WriteLine("** 2.Add a new student                                                   **");
                Console.WriteLine("** 3.Show list student                                                   **");
                Console.WriteLine("** 4.Show student information at faculty of IT                           **");
                Console.WriteLine("** 5.Find Student have averge score =>5                                  **");
                Console.WriteLine("** 6.Sort Student by averge score ascending                              **");
                Console.WriteLine("** 7.Show student information have averge score => 5 and at faculty IT   **");
                Console.WriteLine("** 8.Show student infomation have averge score max and at faculty IT     **");
                Console.WriteLine("** 0.Quit                                                                **");
                Console.WriteLine("*********************************MENU**************************************");
                Console.Write("Select function: ");
                chose = byte.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:

                        List = EnterListStudent();
                        break;
                    case 2:
                        Console.WriteLine("\n***ADD A NEW STUDENT***\n");
                        AddStudent(List);
                        break;

                    case 3:

                        Console.WriteLine("\n****=SHOW LIST STUDENT****\n");
                        ShowListStudent(List);
                        break;
                    case 4:
                        List<Student> ListCNTT = List.Where(s => s.Faculty == "IT").ToList();
                        if (ListCNTT.Count == 0)
                        {
                            Console.WriteLine("THERE NO STUDENT IN FACULTY IT");

                        }
                        else
                            ShowListStudent(ListCNTT);
                        break;
                    case 5:
                        Console.WriteLine("\n***SHOW STUDENT INFORMATION HAVE AVERGE SCORE => 5 ***\n");
                        List<Student> listrs = List.Where(a => a.avergeScore >= 5).ToList();
                        if (listrs.Count == 0)
                        {
                            Console.WriteLine("THERE NO STUDENT HAVE AVERGE SCORE =>5");
                        }
                        else
                            ShowListStudent(listrs);
                        break;

                    case 6:
                        Console.WriteLine("\n***SORT BY AVERGE SCORE ASCENDING****\n");
                        List<Student> Listsort = List.OrderBy(p => p.avergeScore).ToList();
                        ShowListStudent(Listsort);

                        break;
                    case 7:
                        Console.WriteLine("\n***SHOW STUDENT INFORMATION HAVE AVERGE SCORE => 5 AND AT FACULTY OF IT***\n");
                        List<Student> listc = List.Where(a => a.avergeScore >= 5 && a.faculty == "IT").ToList();


                        if (listc.Count == 0)
                        {
                            Console.WriteLine("THERE NO STUDENT HAVE AVERGE SCORE =>5 AND AT FACULTY IT");
                        }
                        else
                            ShowListStudent(listc);
                        break;
                    case 8:
                        Console.WriteLine("Show list student have averge score max and at CNTT");
                        float maxscore = List.Max(m => m.avergeScore);

                        List<Student> listmax = List.Where(m => m.avergeScore == maxscore && m.faculty == "IT").ToList();
                        ShowListStudent(listmax);
                        break;

                }

            } while (chose != 0);


        }

    }
}
