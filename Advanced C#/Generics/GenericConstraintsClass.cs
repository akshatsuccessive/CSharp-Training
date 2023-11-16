using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
    class MyGenericClass<T> where T : class
    {
        private T myStudent;
        public MyGenericClass(T val)
        {
            myStudent = val;
        }   
        public T GetStudent()
        {
            return myStudent;
        }
    }

    class GenericConstraintsClass
    {
        public static void Method()
        {
            MyGenericClass<Student> obj = new MyGenericClass<Student>(new Student(7, "Akshat"));

            Student s = obj.GetStudent();
            Console.WriteLine("{0}, {1}", s.Id, s.Name);
        }
    }
}
