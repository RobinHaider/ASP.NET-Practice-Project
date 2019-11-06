using System.Collections.Generic;
using Jquery_Data_Table___CSharpCorner.Models;

namespace Jquery_Data_Table___CSharpCorner.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Jquery_Data_Table___CSharpCorner.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Jquery_Data_Table___CSharpCorner.Models.DatabaseContext context)
        {
            //Students
            var students = new List<Student>
            {
                //class 5
                new Student(){RollNo = 1, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 2, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Rafiqul Islam", MotherName = "Josna Ara Begum", ClassID = 5, Address = "Abdul-Hoque Bari, Shibpur", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 3, Name = "Abdul Samad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 4, Name = "Sajid Ul Hoque", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 2},

                new Student(){RollNo = 5, Name = "Pabel Islam", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 5, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                //Class 4
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 3},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null),FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 4},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 4, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                //class 3
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 3, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                //class 2
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 2, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                //class 1
                new Student(){RollNo = 1, Name = "Tajimul Hoque Raheel", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 2, Name = "Raihan Saikat", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},

                new Student(){RollNo = 3, Name = "Abdul Ahad Limon", BirthDate = DateTime.ParseExact("2008-01-01","yyyy-MM-dd",null), FatherName = "Sahab Uddin", MotherName = "Rina Akther", ClassID = 1, Address = "Naik-sofi-coloni, Namarbazar, Sitakund", GuardianMobileNumber = "01831541161", GuardianEmail = "robinhaider69@gmail.com", ReligionID = 1},


            };

            foreach (var student in students)
            {
                var studentInDatabase = context.Students.FirstOrDefault(s => s.ClassID == student.ClassID && s.RollNo == student.RollNo);
                if (studentInDatabase == null)
                {
                    context.Students.Add(student);
                }
            }
        }
    }
}
