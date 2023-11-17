﻿using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
}

[Serializable]
public class InvalidStudentNameException : Exception
{
    public InvalidStudentNameException() { }

    public InvalidStudentNameException(string name) : base(String.Format("Invalid Student Name: {0}", name))
    {

    }
}

namespace Exception_Handling
{
    class CustomException
    {
        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);

        }
        public static void Method()
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally runs");
            }
        }
    }
}
