using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTask
{
    class CourseSubject
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        private List<CourseSubject> _subjects = new List<CourseSubject>();
        public Course()
        {
            CourseSubject cs = new CourseSubject();
            cs.Id = "101";
            cs.Name = "English";
            cs.Code = "ENG";
            _subjects.Add(cs);
        }

        public List<CourseSubject> Subjects
        {
            get
            {
                return _subjects;
            }
        }
        public void AddSubjects(CourseSubject subject)
        {
            _subjects.Add(subject);
        }

        public void RemoveSubjects(CourseSubject subject)
        {
            _subjects.Remove(subject);
        }
    }

    class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<string> Courses;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            bool endProcess = false;
            do
            {
                Console.WriteLine("\nEnter a option-\n");
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4. View All Subject");
                Console.WriteLine("5. View All Courses");
                Console.WriteLine("6. View All Students");
                Console.WriteLine("7. Find Subject by Name/Code");
                Console.WriteLine("8. Find Course by Name/Code");
                Console.WriteLine("9. Find Student by Name/Code");
                Console.WriteLine("10. Exit\n");

                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        bool endProcessOfAdding = false;
                        do
                        {
                            bool check = false;
                            
                            Console.Write("\nEnter Subject Id : ");
                            string subId = Console.ReadLine();
                            Console.Write("Enter Subject Name : ");
                            string subName = Console.ReadLine();
                            Console.Write("Enter Subject Code : ");
                            string subCode = Console.ReadLine();

                            CourseSubject cs = new CourseSubject();
                            cs.Id = subId;
                            cs.Name = subName;
                            cs.Code = subCode;
                            c.AddSubjects(cs);

                            Console.WriteLine("\nDo you want to Add More Subjects (Y/N) : ");
                            string AddOption = Console.ReadLine();
                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfAdding = true;
                                    break;
                                case "n":
                                    endProcessOfAdding = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }

                        } while (!endProcessOfAdding);
                        
                        break;


                    case "2":
                        bool endProcessOfCourse = false;
                        do
                        {
                            bool check = false;

                            Console.Write("\nEnter Course Id : ");
                            string courseId = Console.ReadLine();
                            Console.Write("Enter Course Name : ");
                            string courseName = Console.ReadLine();
                            Console.Write("Enter Course Code : ");
                            string courseCode = Console.ReadLine();

                            CourseSubject cs = new CourseSubject();
                            cs.Id = courseId;
                            cs.Name = courseName;
                            cs.Code = courseCode;
                            c.AddSubjects(cs);

                            Console.WriteLine("\nDo you want to Add More Courses (Y/N) : ");
                            string AddOption = Console.ReadLine();
                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfCourse = true;
                                    break;
                                case "n":
                                    endProcessOfCourse = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }

                        } while (!endProcessOfCourse);

                        break;


                    case "3":
                        bool endProcessOfAddingStudent = false;
                        do
                        {
                            Console.Write("\nEnter Student Id : ");
                            string stId = Console.ReadLine();
                            Console.Write("Enter Student Name : ");
                            string stName = Console.ReadLine();
                            Console.Write("Enter Student Code : ");
                            string stCode = Console.ReadLine();


                            Console.WriteLine("\nDo you want to Add More Students (Y/N) : ");
                            string AddOption = Console.ReadLine();
                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfAdding = true;
                                    break;
                                case "n":
                                    endProcessOfAdding = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }
                        } while (!endProcessOfAddingStudent);

                        break;

                    case "4":
                        foreach(var item in c.Subjects)
                        {
                            Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Code);
                        }
                        break;

                    case "10":
                        Console.WriteLine("\n\nThank You................");
                        endProcess = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option, Please try again\n");
                        break;
                }
            } while (!endProcess);

            Console.ReadKey();
        }
    }
}
