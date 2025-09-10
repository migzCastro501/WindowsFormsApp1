﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class StudentInfoClass
    {
        // Delegates
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        // Static variables
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Birthday = "";
        public static string Program = "";
        public static string Gender = "";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        // Static return methods
        public static string GetFirstName(string txt) => FirstName;
        public static string GetLastName(string txt) => LastName;
        public static string GetMiddleName(string txt) => MiddleName;
        public static string GetGender(string txt) => Gender;
        public static string GetProgram(string txt) => Program;
        
        public static string GetBirthday(string txt) => Birthday;
        public static long GetAge(long number) => Age;
        public static long GetContactNo(long number) => ContactNo;
        public static long GetStudentNo(long number) => StudentNo;
    }
}
    

