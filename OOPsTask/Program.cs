using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTask
{
    class Program
    {
        private static void PrintStudent(List<Student> studentsList)
        {
            Console.WriteLine("\n\nAll Students : ");
            foreach (var item in studentsList)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Code);
            }
        }
        private static void PrintCourses()
        {
            Console.WriteLine("\n\nAll Courses : ");
            foreach (var item in Student.Courses)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Code);
            }
        }

        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

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
                switch (option)
                {
                    case "1":
                        if (Student.Courses.Count == 1)
                        {
                            Console.WriteLine("No Courses Added as of Now, Please add a Course first");
                        }
                        else
                        {
                            bool endProcessOfAdding = false;
                            do
                            {
                                PrintCourses();
                                Console.WriteLine("Enter Course Name/Id to Add a Subject");
                                string inputName = Console.ReadLine();

                                Course isCourse = Student.Courses.FirstOrDefault(
                                c => c.Name.ToLower() == inputName.ToLower() || c.Id.ToLower() == inputName.ToLower());

                                Console.Write("\nEnter Subject Id : ");
                                string subId = Console.ReadLine();
                                Console.Write("Enter Subject Name : ");
                                string subName = Console.ReadLine();
                                Console.Write("Enter Subject Code : ");
                                string subCode = Console.ReadLine();

                                CourseSubject newSubject = new CourseSubject();
                                newSubject.Id = subId;
                                newSubject.Name = subName;
                                newSubject.Code = subCode;

                                if (isCourse != null)
                                {
                                    isCourse.AddSubjects(newSubject);
                                    Console.WriteLine("\nSubject added successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Course is not exist\n");
                                }

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
                        }
                        break;


                    case "2":
                        if (studentsList.Count == 0)
                        {
                            Console.WriteLine("No Student Added as of Now, Please add a Student first");
                        }
                        else
                        {
                            bool endProcessOfCourse = false;
                            do
                            {
                                PrintStudent(studentsList);
                                Console.WriteLine("Enter Student Name/Id to Add a Course");
                                string inputName = Console.ReadLine();

                                Student isStudent = studentsList.FirstOrDefault(
                                s => s.Name.ToLower() == inputName.ToLower() || s.Id.ToLower() == inputName.ToLower());

                                Console.Write("\nEnter Course Id : ");
                                string courseId = Console.ReadLine();
                                Console.Write("Enter Course Name : ");
                                string courseName = Console.ReadLine();
                                Console.Write("Enter Course Code : ");
                                string courseCode = Console.ReadLine();

                                Course newCourse = new Course();
                                newCourse.Id = courseId;
                                newCourse.Name = courseName;
                                newCourse.Code = courseCode;

                                if (isStudent != null)
                                {
                                    isStudent.AddCourse(newCourse);
                                    Console.WriteLine("\nCourse added successfully!");
                                }
                                else
                                {
                                    Console.WriteLine("Student is not exist\n");
                                }


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
                        }
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

                            Student newStudent = new Student();
                            newStudent.Id = stId;
                            newStudent.Name = stName;
                            newStudent.Code = stCode;

                            studentsList.Add(newStudent);

                            Console.WriteLine("Student added successfully!");
                            Console.WriteLine("\nDo you want to Add More Students (Y/N) : ");
                            string AddOption = Console.ReadLine();
                            switch (AddOption)
                            {
                                case "Y":
                                    continue;
                                case "y":
                                    continue;
                                case "N":
                                    endProcessOfAddingStudent = true;
                                    break;
                                case "n":
                                    endProcessOfAddingStudent = true;
                                    break;

                                default:
                                    Console.WriteLine("\nInvalid option, Please try again\n");
                                    break;
                            }
                        } while (!endProcessOfAddingStudent);

                        break;

                    case "4":
                        if (Course.Subjects.Count == 0)
                        {
                            Console.WriteLine("No Subjects Added\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\nAll Subjects : ");
                            foreach (var subject in Course.Subjects)
                            {
                                Console.WriteLine("{0}, {1}, {2}", subject.Id, subject.Name, subject.Code);
                            }
                            Console.WriteLine("\n");
                        }
                        break;

                    case "5":
                        if (Student.Courses.Count == 0)
                        {
                            Console.WriteLine("No Courses Added\n");
                        }
                        else
                        {
                            Console.WriteLine("\n\nAll Courses : ");
                            foreach (var course in Student.Courses)
                            {
                                Console.WriteLine("{0}, {1}, {2}", course.Id, course.Name, course.Code);
                            }
                            Console.WriteLine("\n");
                        }
                        break;

                    case "6":
                        if (studentsList.Count == 0)
                        {
                            Console.WriteLine("No Students Added\n");
                        }
                        else
                        {
                            Console.WriteLine("\nAll Students : ");
                            foreach (var student in studentsList)
                            {
                                Console.WriteLine("{0}, {1}, {2}", student.Id, student.Name, student.Code);
                            }
                            Console.WriteLine("\n");
                        }
                        break;

                    case "7":
                        Console.Write("Enter Subject Name or Code: ");
                        string inputSubject = Console.ReadLine().ToLower();

                        CourseSubject foundSubject = Course.Subjects.FirstOrDefault(
                            s => s.Name.ToLower() == inputSubject || s.Code.ToLower() == inputSubject);

                        if (foundSubject != null)
                        {
                            Console.WriteLine("Subject found: {0}, {1}, {2}", foundSubject.Id, foundSubject.Name, foundSubject.Code);
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Subject not found.\n");
                        }
                        break;

                    case "8":
                        Console.Write("Enter Course Name or Code: ");
                        string inputCourse = Console.ReadLine().ToLower();

                        Course foundCourse = Student.Courses.FirstOrDefault(
                            c => c.Name.ToLower() == inputCourse || c.Code.ToLower() == inputCourse);

                        if (foundCourse != null)
                        {
                            Console.WriteLine("Course found: {0}, {1}, {2}", foundCourse.Id, foundCourse.Name, foundCourse.Code);
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Course not found.\n");
                        }
                        break;

                    case "9":
                        Console.Write("Enter Student Name or Code: ");
                        string inputStudent = Console.ReadLine().ToLower();

                        Student foundStudent = studentsList.FirstOrDefault(
                            s => s.Name.ToLower() == inputStudent || s.Code.ToLower() == inputStudent);

                        if (foundStudent != null)
                        {
                            Console.WriteLine("Student found: {0}, {1}, {2}", foundStudent.Id, foundStudent.Name, foundStudent.Code);
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.\n");
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